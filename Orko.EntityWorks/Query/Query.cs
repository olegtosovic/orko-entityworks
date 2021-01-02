using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Provides support for entity crud string generation.
	/// </summary>
	/// <typeparam name="TEntity">Entity type, eg. Person, Customer, Product</typeparam>
	internal sealed class Query<TEntity> where TEntity : Entity, new()
    {
        #region Constructors
        /// <summary>
        /// Creates instance of query object.
        /// </summary>
        private Query()
        {

        }
        #endregion

        #region Public static methods
        /// <summary>
        /// Add language table join for entity object.
        /// </summary>
        public static void GenerateLanguageJoin(EntityContext<TEntity> entityContext, Query query)
        {
            // Join, where language table.
            List<QueryCondition> joinQueryConditions = new List<QueryCondition>();
            foreach (var parameter in entityContext.PrimaryKeyParameters)
            {
                //joinQueryConditions.Add(new QueryCondition(parameter.SqlParameterName, QueryOp.Equal, parameter.SqlLangParameterName));
                joinQueryConditions.Add(new QueryCondition(parameter.SqlParameterName, QueryOp.Equal, parameter.SqlLangParameterName));
            }
            query.Join(entityContext.SqlLanguageTablePathWithSchema, joinQueryConditions.ToArray());
        }
        /// <summary>
        /// Generates parametrized sql select string for
        /// this entity type ready to be passed to IDbCommand object. 
        /// </summary>
        public static string GenerateSelectQuery(EntityContext<TEntity> entityContext)
        {
            // Create query instance.
            Query query = new Query();

            // Set from clause.
            query.From(entityContext.SqlTablePathWithSchema);

            // If using language tables.
            if (entityContext.HasLanguageTable)
            {
                // Select columns from both tables.
                // This is special version of select only used by internals of entity works.
                query.Select(entityContext, true);

                // Join, where language table.
                List<QueryCondition> joinQueryConditions = new List<QueryCondition>();
                List<QueryCondition> whereQueryConditions = new List<QueryCondition>();
                foreach (var parameter in entityContext.PrimaryKeyParameters.Where(x => x.IsLanguage == false))
                {
                    joinQueryConditions.Add(new QueryCondition(parameter.SqlParameterName, QueryOp.Equal, parameter.SqlLangParameterName));
                    whereQueryConditions.Add(new QueryCondition(parameter.SqlParameterName, QueryOp.Equal, parameter.ParameterNameWithMonkey));
                }
                query.Join(entityContext.SqlLanguageTablePathWithSchema, joinQueryConditions.ToArray());
                query.Where(whereQueryConditions.ToArray());

                // Specific language code.
                Parameter languageCode = entityContext.LanguageCodeParameter;
                query.Where(languageCode.SqlLangParameterName, QueryOp.Equal, languageCode.ParameterNameWithMonkey);
            }
            else
            {
                // Select columns from both tables.
                // This is special version of select only used by internals of entity works.
                query.Select(entityContext);

                // Dynamically add select parameters.
                foreach (var parameter in entityContext.PrimaryKeyParameters.Where(x => x.IsLanguage == false))
                    query.Where(parameter.SqlParameterName, QueryOp.Equal, parameter.ParameterNameWithMonkey);
            }

            return query.ToString();
        }
        /// <summary>
        /// Generates parametrized sql insert string for
        /// this entity type ready to be passed to IDbCommand object.
        /// </summary>
        public static string GenerateInsertQuery(EntityContext<TEntity> entityContext)
        {
            // Insert query.
            Query query = new Query();
            Query languageQuery = new Query();

            // Identity parameters.
            var identityParameters = entityContext.Parameters.Values.Where(x => x.IsIdentity);
            if (identityParameters.Count() > 1)
                throw new TableDefinitionException("There can be only one identity column defined in table.", null);

            // Build insert query.
            var queryParameters = entityContext.Parameters.Values.Where(x => !x.IsLanguage && !x.IsLanguageCode);
            string returnIdentity = string.Empty;
			string returnTimestamp = string.Empty;
            foreach (var parameter in queryParameters)
            {
				if (parameter.IsTimestamp)
					continue;

                if (parameter.IsIdentity)
                    returnIdentity = "SET " + parameter.ParameterNameWithMonkey + " = SCOPE_IDENTITY();";
                //else query.Insert(parameter.ParameterName, parameter.ParameterNameWithMonkey);
                else query.Insert(parameter.SqlParameterName, parameter.ParameterNameWithMonkey);
            }
            query.Into(entityContext.SqlTablePathWithSchema);

            // Build language insert query.
            if (entityContext.HasLanguageTable)
            {
                // Get language table parameters.
                List<Parameter> languageQueryParameters = new List<Parameter>(entityContext.PrimaryKeyParameters);
                languageQueryParameters.AddRange(entityContext.Parameters.Values.Where(x => x.IsLanguage || x.IsLanguageCode));

                // Add parameters to query.
                foreach (var parameter in languageQueryParameters)
                    languageQuery.Insert(parameter.SqlParameterName, parameter.ParameterNameWithMonkey);
                languageQuery.Into(entityContext.SqlLanguageTablePathWithSchema);
            }

			// Return complete insert string.
            return query.ToString() + Environment.NewLine + returnIdentity + Environment.NewLine + languageQuery.ToString();
        }
        /// <summary>
        /// Generates parametrized sql update string for
        /// this entity type ready to be passed to IDbCommand object. 
        /// </summary>
        public static string GenerateUpdateQuery(EntityContext<TEntity> entityContext)
        {
            // Update query.
            Query query = new Query();
            Query languageQuery = new Query();

            // Build update query.
            query.Update(entityContext.SqlTablePathWithSchema);
            var queryParameters = entityContext.Parameters.Values.Where(x => !x.IsLanguage && !x.IsLanguageCode && !x.IsPrimary && !x.IsIdentity && !x.IsTimestamp);
            foreach (var parameter in queryParameters)
                query.Set(parameter.SqlParameterName, parameter.ParameterNameWithMonkey);
            foreach (var parameter in entityContext.PrimaryKeyParameters)
                query.Where(parameter.SqlParameterName, QueryOp.Equal, parameter.ParameterNameWithMonkey);

            // If using language table.
            if (entityContext.HasLanguageTable)
            {
                // Build language query.
                var languageQueryParameters = entityContext.Parameters.Values.Where(x => x.IsLanguage && !x.IsLanguageCode && !x.IsPrimary);
                languageQuery.Update(entityContext.SqlLanguageTablePathWithSchema);
                foreach (var parameter in languageQueryParameters)
                    languageQuery.Set(parameter.SqlLangParameterName, parameter.ParameterNameWithMonkey);
                var languageQueryWhereParameters = entityContext.Parameters.Values.Where(x => x.IsPrimary);
                foreach (var parameter in languageQueryWhereParameters)
                    languageQuery.Where(parameter.SqlLangParameterName, QueryOp.Equal, parameter.ParameterNameWithMonkey);
                
            }
            return query.ToString() + Environment.NewLine + languageQuery.ToString();
        }
        /// <summary>
        /// Generates parametrized sql delete string for
        /// this entity type ready to be passed to IDbCommand object. 
        /// </summary>
        public static string GenerateDeleteQuery(EntityContext<TEntity> entityContext)
        {
            // Delete query.
            Query query = new Query();
            Query languageQuery = new Query();

            // Build delete query.
            query.Delete(entityContext.SqlTablePathWithSchema);
            query.From(entityContext.SqlTablePathWithSchema);
            foreach (var parameter in entityContext.PrimaryKeyParameters.Where(x => x.IsLanguage == false))
                query.Where(parameter.SqlParameterName, QueryOp.Equal, parameter.ParameterNameWithMonkey);

            // If using language tables.
            if (entityContext.HasLanguageTable)
            {
                languageQuery.Delete(entityContext.SqlLanguageTablePathWithSchema);
                languageQuery.From(entityContext.SqlLanguageTablePathWithSchema);
                foreach (var parameter in entityContext.PrimaryKeyParameters.Where(x => x.IsLanguage == false))
                    languageQuery.Where(parameter.SqlParameterName, QueryOp.Equal, parameter.ParameterNameWithMonkey);
            }
            return languageQuery.ToString() + Environment.NewLine + query.ToString();
        }
        #endregion
    }

    /// <summary>
    /// Provides support for database query operations.
    /// </summary>
    public sealed class Query : QuerySegment
    {
        #region Members
        private int m_parameterOrdinal;
        private bool m_formatQueryText;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of query object.
        /// </summary>
        public Query()
        {
            // Initialization.
            m_parameterOrdinal = 1;
            AutoGroupBy = false;

            // Create instances.
            SelectSegment = new List<object>();
            InsertSegment = new List<object>();
            DeleteSegment = new List<object>();
            ValuesSegment = new List<object>();
            SetColumnSegment = new List<object>();
            SetValueSegment = new List<object>();
            WhereSegment = new List<QueryCondition>();
            GroupSegment = new List<object>();
            OrderSegment = new List<Tuple<object, QueryOrder>>();
            JoinSegment = new List<QueryJoin>();
            HavingSegment = new List<QueryCondition>();

            // If debug mode, format query text.
            #if DEBUG
            m_formatQueryText = true;
            #endif
        }
        #endregion

        #region Properties
        /// <summary>
        /// If set to true, all non-aggregate select items will be added to group.
        /// </summary>
        public bool AutoGroupBy { get; set; }
        /// <summary>
        /// Starting row number.
        /// Sql server 2012+ only.
        /// </summary>
        public int? Offset { get; private set; }
        /// <summary>
        /// How many rows from starting row (offset).
        /// Sql server 2012+ only.
        /// </summary>
        public int? Fetch { get; private set; }
        #endregion

        #region Public methods
        /// <summary>
        /// Creates copy of query object.
        /// </summary>
        /// <returns>Query object</returns>
        public Query Clone()
        {
            // New query.
            Query query = new Query();

            // Deep copy.
            using (MemoryStream memoryStream = new MemoryStream(10))
            {
                //IFormatter formatter = new BinaryFormatter();
                //formatter.Serialize(memoryStream, this);
                //memoryStream.Seek(0, SeekOrigin.Begin);
                //query = formatter.Deserialize(memoryStream) as Query;
            }

            // Return query.
            return query;
        }
        /// <summary>
        /// Gets current sql text.
        /// </summary>
        /// <returns>Sql text</returns>
        public string GetSqlText()
        {
            return this.ToString();
        }
        /// <summary>
        /// Gets formatted sql text.
        /// </summary>
        /// <returns>Formatted sql text</returns>
        public string GetFormattedSqlText()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Public static methods
        /// <summary>
        /// Filters out all parameters that do not inherit from IQuerySegment except string.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static IEnumerable<object> GetQuerySegmentsParameters(IEnumerable<object> parameters)
        {
            return parameters.Where(x => x is IQuerySegment || x is string);
        }
        /// <summary>
        /// Wraps value with single quotes.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object Quote(object value)
        {
            // Sql injection check.
            string _value = value.ToString();
            if (_value.Contains("'"))
                throw new Exception("Vrijednost parametra ne smije sadržavati jednostruke navodnike.");

			// Ako je datum.
			if (value is DateTime || value is DateTime?)
				_value = ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");

			// Ako je boolean.
			if (value is bool || value is bool?)
				_value = ((bool)value == true) ? "true" : "false";

			// Ako je string dodaj N.
			if (value is string)
				return "N'" + _value + "'";

			// Return quoted string.
			else return "'" + _value + "'";
        }
		/// <summary>
		/// Wraps value with single quotes with N.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static object QuoteN(object value)
		{
			return "N" + Quote(value);
		}
		#endregion

		#region Segment
		private List<object> SelectSegment { get; set; }
        private List<object> InsertSegment { get; set; }
        private List<object> DeleteSegment { get; set; }
        private List<object> ValuesSegment { get; set; }
        private List<object> SetColumnSegment { get; set; }
        private List<object> SetValueSegment { get; set; }
        private object IntoSegment { get; set; }
        private object UpdateSegment { get; set; }
        private object FromSegment { get; set; }
        private List<QueryCondition> WhereSegment { get; set; }
        private List<object> GroupSegment { get; set; }
        private List<Tuple<object, QueryOrder>> OrderSegment { get; set; }
        private List<QueryJoin> JoinSegment { get; set; }
        private List<QueryCondition> HavingSegment { get; set; }
        #endregion

        #region Statements

        #region Select
        /// <summary>
        /// Adds column name to select list.
        /// </summary>
        /// <param name="ColumnName">Column name list</param>
        /// <returns>Query instance</returns>
        public Query Select(string column, string alias = null)
        {
			// Add to list.
			if (string.IsNullOrWhiteSpace(alias) == false)
				SelectSegment.Add(column + " AS " + alias.Trim());
			else SelectSegment.Add(column);

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds aggregate function to select list.
        /// </summary>
        /// <param name="queryAggregate">Query aggregate list</param>
        /// <returns>Query instance</returns>
        public Query Select(QueryFunction queryFunction, string alias = null)
        {
            // Set alias.
            queryFunction.Alias = alias;

            // Add to list.
            SelectSegment.Add(queryFunction);

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds query calculation to select list.
        /// </summary>
        /// <param name="queryCalculations">Query calculation expression list</param>
        /// <returns></returns>
        public Query Select(QueryCalculation queryCalculation, string alias = null)
        {
            // Set alias.
            queryCalculation.Alias = alias;

            // Add to list.
            SelectSegment.Add(queryCalculation);

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds query as select list item.
        /// </summary>
        /// <param name="query">Query object</param>
        /// <param name="alias">Query alias</param>
        /// <returns>Query instance</returns>
        public Query Select(Query query, string alias = null)
        {
            // Set alias.
            query.Alias = alias;

            // Add to list.
            SelectSegment.Add(query);

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds all entity columns infered from entity type.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns>Query instance</returns>
        public Query Select<TEntity>() where TEntity : Entity, new()
        {
            // Get entity context.
            EntityContext<TEntity> entityContext = EntityContext<TEntity>.GetEntityContext();

            // Return instance.
            return Select<TEntity>(entityContext, entityContext.HasLanguageTable);
        }

        /// <summary>
        /// Special case select method intended for entity context type initialization time.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="partialInstance">Entity context partial instance</param>
        /// <param name="includeLanguageColumns">Should language columns be included</param>
        /// <returns>Query instance</returns>
        internal Query Select<TEntity>(EntityContext<TEntity> partialInstance, bool includeLanguageColumns = false) where TEntity : Entity, new()
        {
            // Add entity parameters (columns).
            if (includeLanguageColumns)
            {
                foreach (var parameter in partialInstance.Parameters)
                {
                    if (parameter.Value.IsLanguage == false && parameter.Value.IsLanguageCode == false)
                        SelectSegment.Add(parameter.Value.SqlParameterName);
                    else SelectSegment.Add(parameter.Value.SqlLangParameterName);
                }
            }
            else SelectSegment.AddRange(partialInstance.Parameters.Values
                .Where(x => x.IsLanguage == false && x.IsLanguageCode == false)
                .Select(x => x.SqlParameterName).ToList());

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Insert
        /// <summary>
        /// Adds insert items to insert list.
        /// </summary>
        /// <param name="column">Column name</param>
        /// <param name="value">Column value</param>
        /// <returns>Query instance</returns>
        internal Query Insert(string column, object value)
        {
            // Add to list.
            InsertSegment.Add(column);
            ValuesSegment.Add(value);

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Generates insert name value parameters for specific entity.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="partialInstance">Entity context partial instance</param>
        /// <param name="includeLanguageColumns">Should language columns be included</param>
        /// <returns>Query instance</returns>
        internal Query Insert<TEntity>(EntityContext<TEntity> partialInstance, bool includeLanguageColumns = false) where TEntity : Entity, new()
        {
            return this;
        }
        #endregion

        #region Update
        /// <summary>
        /// Sets update table name.
        /// </summary>
        /// <param name="tableName">Table name to update</param>
        /// <returns>Query instance</returns>
        public Query Update(string tableName)
        {
            // Add to list.
            UpdateSegment = tableName;

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Delete
        /// <summary>
        /// Adds delete items to delete list.
        /// </summary>
        /// <param name="tableNames">Table name list</param>
        /// <returns>Query instance</returns>
        internal Query Delete(params string[] tableNames)
        {
            // Add to list.
            DeleteSegment.AddRange(tableNames.Where(x => !string.IsNullOrWhiteSpace(x)));

            // Mark as not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Into
        /// <summary>
        /// Sets insert table name.
        /// </summary>
        /// <param name="tableName">Table name to insert to</param>
        /// <returns>Query instance</returns>
        public Query Into(string tableName)
        {
            // Add to list.
            IntoSegment = tableName;

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Set
        /// <summary>
        /// Adds set items to set list.
        /// </summary>
        /// <param name="column">Column name</param>
        /// <param name="value">Column value</param>
        /// <returns>Query instance</returns>
        public Query Set(string column, object value)
        {
            // Add to list.
            SetColumnSegment.Add(column);
            SetValueSegment.Add(value);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region From
        /// <summary>
        /// Sets from query statment.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="alias">Alias</param>
        public Query From(string tableName, string alias = null, LockHint? lockHint = null)
        {
            // Add to list.
            if (string.IsNullOrEmpty(alias))
                FromSegment = tableName;
            else FromSegment = tableName + " AS " + alias;

            // If hint used.
            if (lockHint.HasValue)
            {
                if (lockHint == LockHint.ExclusiveLock)
                    FromSegment += " WITH (XLOCK)";
                else if (lockHint == LockHint.UpdateLock)
                    FromSegment += " WITH (UPDLOCK)";
            }

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Sets from query statmet.
        /// </summary>
        /// <param name="query">Subquery</param>
        /// <param name="alias">Alias</param>
        public Query From(Query query, string alias)
        {
            // Add to list.
            FromSegment = query;

            // Set alias.
            query.Alias = alias;

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Sets from query statment, if entity has language table also adds inner join to language table.
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="alias">Alias</param>
        public Query From<TEntity>(string alias = null) where TEntity : Entity, new()
        {
            // Get entity context.
            var entityContext = EntityContext<TEntity>.GetEntityContext();

			// Get query context.
			var queryContext = QueryContext.GetAmbientQueryContext();

            // Set from segment.
            string tableName = entityContext.SqlTablePathWithSchema;
            if (string.IsNullOrEmpty(alias))
                FromSegment = tableName;
            else FromSegment = tableName + " AS " + alias;

            // Add language inner join.
            if (entityContext.HasLanguageTable)
            {
                List<QueryCondition> joinQueryConditions = new List<QueryCondition>();
                foreach (var parameter in entityContext.PrimaryKeyParameters)
                {
                    joinQueryConditions.Add(new QueryCondition(parameter.SqlParameterName, QueryOp.Equal, parameter.SqlLangParameterName));
                }
                joinQueryConditions.Add(
                    new QueryCondition(entityContext.LanguageCodeParameter.SqlLangParameterName, QueryOp.Equal, Query.Quote(queryContext.LanguageCode)));
                this.Join(entityContext.SqlLanguageTablePathWithSchema, joinQueryConditions.ToArray());
            }

            // Return instance.
            return this;
        }
        #endregion

        #region Join
        /// <summary>
        /// Adds inner join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="leftColumn">Left column name</param>
        /// <param name="rightColumn">Right column name</param>
        /// <returns>Query instance</returns>
        public Query Join(string tableName, string leftColumn, string rightColumn)
        {
            // Create query condition.
            List<QueryCondition> queryConditions = new List<QueryCondition>();
            queryConditions.Add(new QueryCondition(leftColumn, QueryOp.Equal, rightColumn));

            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Inner, tableName, null, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds inner join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="queryConditions">Query condition list</param>
        /// <returns>Query instance</returns>
        public Query Join(string tableName, params QueryCondition[] queryConditions)
        {
            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Inner, tableName, null, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds inner join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="alias">Table alias</param>
        /// <param name="queryConditions">Query condition list</param>
        /// <returns>Query instance</returns>
        public Query Join(string tableName, string alias, params QueryCondition[] queryConditions)
        {
            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Inner, tableName, alias, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds left join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="leftColumn">Left column name</param>
        /// <param name="rightColumn">Right column name</param>
        /// <returns>Query instance</returns>
        public Query JoinLeft(string tableName, string leftColumn, string rightColumn)
        {
            // Create query condition.
            List<QueryCondition> queryConditions = new List<QueryCondition>();
            queryConditions.Add(new QueryCondition(leftColumn, QueryOp.Equal, rightColumn));

            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Left, tableName, null, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds left join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="queryConditions">Query condition list</param>
        /// <returns>Query instance</returns>
        public Query JoinLeft(string tableName, params QueryCondition[] queryConditions)
        {
            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Left, tableName, null, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds Left join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="alias">Table alias</param>
        /// <param name="queryConditions">Query condition list</param>
        /// <returns>Query instance</returns>
        public Query JoinLeft(string tableName, string alias, params QueryCondition[] queryConditions)
        {
            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Left, tableName, alias, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds right join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="leftColumn">Left column name</param>
        /// <param name="rightColumn">Right column name</param>
        /// <returns>Query instance</returns>
        public Query JoinRight(string tableName, string leftColumn, string rightColumn)
        {
            // Create query condition.
            List<QueryCondition> queryConditions = new List<QueryCondition>();
            queryConditions.Add(new QueryCondition(leftColumn, QueryOp.Equal, rightColumn));

            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Right, tableName, null, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds right join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="queryConditions">Query condition list</param>
        /// <returns>Query instance</returns>
        public Query JoinRight(string tableName, params QueryCondition[] queryConditions)
        {
            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Right, tableName, null, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds right join item to join list.
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <param name="alias">Table alias</param>
        /// <param name="queryConditions">Query condition list</param>
        /// <returns>Query instance</returns>
        public Query JoinRight(string tableName, string alias, params QueryCondition[] queryConditions)
        {
            // Create query join.
            QueryJoin queryJoin = new QueryJoin(QueryJoinType.Right, tableName, alias, queryConditions.AsEnumerable());

            // Add to list.
            JoinSegment.Add(queryJoin);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Where
        /// <summary>
        /// Adds where item to where list.
        /// </summary>
        /// <param name="queryCondition">Query condition</param>
        /// <returns>Query instance</returns>
        internal Query Where(params QueryCondition[] queryConditions)
        {
            // Add to list.
            WhereSegment.AddRange(queryConditions);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds where item to where list.
        /// </summary>
        /// <param name="leftExpression">Column name</param>
        /// <param name="queryOperator">Query operator</param>
        /// <param name="rightExpression">Object value</param>
        /// <param name="lastOperator">After condition operator.</param>
        /// <returns>Query instance</returns>
        public Query Where(object leftExpression, QueryOp queryOperator, object rightExpression, QueryOp lastOperator = QueryOp.And)
        {
            // Create query condition.
            QueryCondition queryCondition = new QueryCondition(leftExpression, queryOperator, rightExpression, lastOperator: lastOperator);

            // Add to list.
            WhereSegment.Add(queryCondition);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds where item to where list.
        /// </summary>
        /// <param name="leftCondition">Left query condition</param>
        /// <param name="queryOperator">Query operator</param>
        /// <param name="rightCondition">Right condition</param>
        /// <param name="lastOperator">After condition operator.</param>
        /// <returns>Query instance</returns>
        public Query Where(QueryCondition leftCondition, QueryOp queryOperator, QueryCondition rightCondition, QueryOp lastOperator = QueryOp.And)
        {
            // Create query condition.
            QueryCondition queryCondition = new QueryCondition(leftCondition, queryOperator, rightCondition, lastOperator: lastOperator);

            // Add to list.
            WhereSegment.Add(queryCondition);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region OrderBy
        /// <summary>
        /// Adds order item to order list.
        /// </summary>
        /// <param name="orderItem">Column name or expression</param>
        /// <param name="orderType">Ascending / descending</param>
        /// <returns>Query instance</returns>
        public Query OrderBy(object orderItem, QueryOrder orderType)
        {
            // Add to list.
            OrderSegment.Add(new Tuple<object, QueryOrder>(orderItem, orderType));

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

		/// <summary>
		/// Clears order by list.
		/// </summary>
		public void OrberByClear()
		{
			// Clear order by list.
			OrderSegment.Clear();
		}
        #endregion

        #region GroupBy
        /// <summary>
        /// Adds group item to group list.
        /// </summary>
        /// <param name="groupItem">Column name or expression</param>
        /// <returns>Query instance</returns>
        public Query GroupBy(object groupItem)
        {
            // Add to list.
            GroupSegment.Add(groupItem);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Having
        /// <summary>
        /// Adds where item to where list.
        /// </summary>
        /// <param name="leftExpression">Column name</param>
        /// <param name="queryOperator">Query operator</param>
        /// <param name="rightExpression">Object value</param>
        /// <param name="lastOperator">After condition operator.</param>
        /// <returns>Query instance</returns>
        public Query Having(object leftExpression, QueryOp queryOperator, object rightExpression, QueryOp lastOperator = QueryOp.And)
        {
            // Create query condition.
            QueryCondition queryCondition = new QueryCondition(leftExpression, queryOperator, rightExpression, lastOperator: lastOperator);

            // Add to list.
            HavingSegment.Add(queryCondition);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }

        /// <summary>
        /// Adds having item to having list.
        /// </summary>
        /// <param name="leftCondition">Left query condition</param>
        /// <param name="queryOperator">Query operator</param>
        /// <param name="rightCondition">Right condition</param>
        /// <param name="lastOperator">After condition operator.</param>
        /// <returns></returns>
        public Query Having(QueryCondition leftCondition, QueryOp queryOperator, QueryCondition rightCondition, QueryOp lastOperator = QueryOp.And)
        {
            // Create query condition.
            QueryCondition queryCondition = new QueryCondition(leftCondition, queryOperator, rightCondition, lastOperator: lastOperator);

            // Add to list.
            WhereSegment.Add(queryCondition);

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Skip
        /// <summary>
        /// Offsets n rows.
        /// </summary>
        /// <param name="skipRows">Number of rows to skip.</param>
        /// <returns>Query instance</returns>
        public Query Skip(int skipRows)
        {
            // Set skip segment.
            Offset = skipRows;

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #region Take
        /// <summary>
        /// Takes n rows starting from skip rows.
        /// </summary>
        /// <param name="takeRows"></param>
        /// <returns></returns>
        public Query Take(int takeRows)
        {
            // Set take segment.
            Fetch = takeRows;

            // Mark sa not builded.
            Builded = false;

            // Return instance.
            return this;
        }
        #endregion

        #endregion

        #region Parametrization and values
        /// <summary>
        /// Validates expression value.
        /// </summary>
        /// <param name="expression"></param>
        private void ValidateValue(object expression)
        {

        }
        /// <summary>
        /// Creates parameter from expression if expression is sql value.
        /// </summary>
        /// <param name="expression">Query segment expression</param>
        private void ProcessValue(object expression)
        {

        }
        /// <summary>
        /// Gets next parameter name for parametrized sql query.
        /// </summary>
        /// <returns>Sql paramter name</returns>
        private string GetNextParameterName()
        {
            // Create parameter name.
            string parameterName = "@param" + m_parameterOrdinal;
            m_parameterOrdinal++;
            return parameterName;
        }
        #endregion

        #region Build segment
        /// <summary>
        /// Builds select segment to string.
        /// </summary>
        /// <returns>Select segment</returns>
        private string BuildSelect()
        {
            // Select string.
            StringBuilder select = new StringBuilder();

            // Append select statement.
            select.Append("SELECT ");

            // Build string.
            foreach (object selectItem in SelectSegment)
            {
                string appendItem = Environment.NewLine;
                if (selectItem == SelectSegment.Last())
                {
                    // If item matches value type.

                    // If item matches string type.

                    // If item matches segment type.

                    if (selectItem is string)
                    {
                        appendItem += selectItem + "";
                        select.Append(appendItem);
                    }
                    else if (selectItem is QueryFunction)
                    {
                        QueryFunction queryFunction = selectItem as QueryFunction;
                        if (string.IsNullOrWhiteSpace(queryFunction.Alias))
                            appendItem += queryFunction.ToString() + "";
                        else appendItem += queryFunction.ToString() + " AS " + queryFunction.Alias;
                        select.Append(appendItem);
                    }
                    else if (selectItem is QueryCalculation)
                    {
                        QueryCalculation queryCalculation = selectItem as QueryCalculation;
                        if (string.IsNullOrWhiteSpace(queryCalculation.Alias))
                            appendItem += queryCalculation.ToString() + "";
                        else appendItem += queryCalculation.ToString() + " AS " + queryCalculation.Alias;
                        select.Append(appendItem);
                    }
                    else if (selectItem is Query)
                    {
						//Query subQuery = selectItem as Query;
						//if (string.IsNullOrWhiteSpace(subQuery.Alias) == false)
						//    appendItem += "(" + subQuery.ToString() + ")" + " AS " + subQuery.Alias;
						//else appendItem += "(" + subQuery.ToString() + ")" + "";
						//select.Append(appendItem);

						Query subQuery = selectItem as Query;
						subQuery.Enclosed = true;
						if (string.IsNullOrWhiteSpace(subQuery.Alias) == false)
							appendItem += subQuery.ToString() + " AS " + subQuery.Alias;
						else appendItem += subQuery.ToString() + "";
						select.Append(appendItem);
					}
                }
                else
                {
                    if (selectItem is string)
                    {
                        appendItem += selectItem + ", ";
                        select.Append(appendItem);
                    }
                    else if (selectItem is QueryFunction)
                    {
                        QueryFunction queryFunction = selectItem as QueryFunction;
                        if (string.IsNullOrWhiteSpace(queryFunction.Alias))
                            appendItem += queryFunction.ToString() + ",";
                        else appendItem += queryFunction.ToString() + " AS " + queryFunction.Alias + ",";
                        select.Append(appendItem);
                    }
                    else if (selectItem is QueryCalculation)
                    {
                        QueryCalculation queryCalculation = selectItem as QueryCalculation;
                        if (string.IsNullOrWhiteSpace(queryCalculation.Alias))
                            appendItem += queryCalculation.ToString() + ",";
                        else appendItem += queryCalculation.ToString() + " AS " + queryCalculation.Alias + ",";
                        select.Append(appendItem);
                    }
                    else if (selectItem is Query)
                    {
						//Query subQuery = selectItem as Query;
						//if (string.IsNullOrWhiteSpace(subQuery.Alias) == false)
						//    appendItem += "(" + subQuery.ToString() + ")" + " AS " + subQuery.Alias + ", ";
						//else appendItem += "(" + subQuery.ToString() + ")" + ", ";
						//select.Append(appendItem);

						Query subQuery = selectItem as Query;
						subQuery.Enclosed = true;
						if (string.IsNullOrWhiteSpace(subQuery.Alias) == false)
							appendItem += subQuery.ToString() + " AS " + subQuery.Alias;
						else appendItem += subQuery.ToString() + "";
						select.Append(appendItem);
					}
                }
            }

            // Return select string.
            return ReturnBuildSegment(select.ToString());
        }
        /// <summary>
        /// Builds insert segment to string.
        /// </summary>
        /// <returns></returns>
        private string BuildInsert()
        {
            // Select string.
            StringBuilder insert = new StringBuilder();

            // Append select statement.
            insert.Append("(");

            // Build insert.
            foreach (object insertItem in InsertSegment)
            {
                if (insertItem == InsertSegment.Last())
                {
                    string appendItem = insertItem + ") VALUES (";
                    insert.Append(appendItem);
                }
                else
                {
                    string appendItem = insertItem + ", ";
                    insert.Append(appendItem);
                }
            }

            // Build values.
            foreach (object valueItem in ValuesSegment)
            {
                if (valueItem == ValuesSegment.Last())
                {
                    string appendItem = valueItem + ")";
                    insert.Append(appendItem);
                }
                else
                {
                    string appendItem = valueItem + ", ";
                    insert.Append(appendItem);
                }
            }

            // Return insert string.
            return ReturnBuildSegment(insert.ToString());
        }
        /// <summary>
        /// Builds update segment to string.
        /// </summary>
        /// <returns></returns>
        private string BuildUpdate()
        {
            // Update string.
            StringBuilder update = new StringBuilder();

            // Append update statment.
            update.Append("UPDATE ");

            // Build update.
            update.Append(UpdateSegment);

            // Return update string.
            return ReturnBuildSegment(update.ToString());
        }
        /// <summary>
        /// Builds delete segment to string.
        /// </summary>
        /// <returns></returns>
        private string BuildDelete()
        {
            // Delete string.
            StringBuilder delete = new StringBuilder();

            // Append delete statment.
            delete.Append("DELETE ");

            // Build delete;
            foreach (object deleteItem in DeleteSegment)
            {
                if (deleteItem == DeleteSegment.Last())
                {
                    string appendItem = deleteItem + "";
                    delete.Append(appendItem);                    
                }
                else
                {
                    string appendItem = deleteItem + ", ";
                    delete.Append(appendItem);
                }
            }

            // Return delete string.
            return ReturnBuildSegment(delete.ToString());
        }
        /// <summary>
        /// Builds set segment to string.
        /// </summary>
        /// <returns></returns>
        private string BuildSet()
        {
            // Set string.
            StringBuilder set = new StringBuilder();

            // Append select statement.
            set.Append("SET ");

            // Build set.
            for (int i=0; i<SetColumnSegment.Count; i++)
            {
                // Get set and value item.
                var setItem = SetColumnSegment[i];
                var valueItem = SetValueSegment[i];

                // If last item.
                if (i == SetColumnSegment.Count - 1)
                    set.Append(setItem + " = " + valueItem);
                else set.Append(setItem + " = " + valueItem + ", ");
            }

            // Return set string.
            return ReturnBuildSegment(set.ToString());
        }
        /// <summary>
        /// Builds into segment to string.
        /// </summary>
        /// <returns></returns>
        private string BuildInto()
        {
            // Into string.
            StringBuilder into = new StringBuilder();

            // Append from statment.
            into.Append("INSERT INTO ");

            // Build into.
            into.Append(IntoSegment);

            // Return insert string.
            return ReturnBuildSegment(into.ToString());
        }
        /// <summary>
        /// Builds from segment to string.
        /// </summary>
        /// <returns>From segment</returns>
        private string BuildFrom()
        {
            // From string.
            StringBuilder from = new StringBuilder();

            // Append from statment.
            from.Append("FROM ");

            // Build string.
            if (FromSegment is string)
            {
                from.Append(FromSegment);
            }
            else if (FromSegment is Query)
            {
                Query query = FromSegment as Query;
                from.Append("(" + query.ToString() + ") AS " + query.Alias);
            }

            // Return from string.
            return ReturnBuildSegment(from.ToString());
        }
        /// <summary>
        /// Builds join segment to string.
        /// </summary>
        /// <returns></returns>
        private string BuildJoin()
        {
            // Join string.
            StringBuilder join = new StringBuilder();

            // Build string.
            foreach (QueryJoin queryJoin in JoinSegment)
            {
                join.Append(queryJoin.ToString());
            }

            // Return join segment.
            return join.ToString();
        }
        /// <summary>
        /// Builds where segment.
        /// </summary>
        /// <returns>Where segment</returns>
        private string BuildWhere()
        {
            // Where string.
            StringBuilder where = new StringBuilder();

            // Append where statment.
            where.Append("WHERE ");

            // Query search condition.
            QuerySearchCondition querySearchCondition = new QuerySearchCondition(WhereSegment.AsEnumerable());

            // Append search condition.
            where.Append(querySearchCondition.ToString());

            // Return where string.
            return ReturnBuildSegment(where.ToString());
        }
        /// <summary>
        /// Builds order segment to string.
        /// </summary>
        /// <returns>Order segment</returns>
        private string BuildOrder()
        {
            // Order string.
            StringBuilder order = new StringBuilder();

            // Append order clause.
            order.Append("ORDER BY ");

            // Build order.
            foreach (var orderItem in OrderSegment)
            {
				// Enclosing.
				if (orderItem.Item1 is Query)
				{
					var subquery = orderItem.Item1 as Query;
					subquery.Enclosed = true;
				}

				// Comma handling.
                if (orderItem == OrderSegment.Last())
                    order.Append(orderItem.Item1 + " " + orderItem.Item2.ToString().ToUpper());
                else order.Append(orderItem.Item1 + " " + orderItem.Item2.ToString().ToUpper() + ",");
            }

            // Return order string.
            return ReturnBuildSegment(order.ToString());
        }
        /// <summary>
        /// Builds group segment to string.
        /// </summary>
        /// <returns>Group segment</returns>
        private string BuildGroup()
        {
            // Group string.
            StringBuilder group = new StringBuilder();

            // If auto group true.
            if (AutoGroupBy)
            {
                // If group segment contains any custom group by fields throw error.
                if (GroupSegment.Any())
                    throw new Exception("To explicitly add group items to query set AutoGroupBy property to false.");

                // Add all non aggregate items.
                foreach (var item in SelectSegment)
                {
                    if (item is QueryFunction)
                    {
                        var function = item as QueryFunction;
                        if (function.PartOfGroupBy == false)
                            continue;
                    }
                    GroupSegment.Add(item);                    
                }
            }

            // If group segment contains any.
            if (GroupSegment.Any())
            {
                // Append group clause.
                group.Append("GROUP BY ");

                // Build group.
                foreach (var groupItem in GroupSegment)
                {
                    if (groupItem == GroupSegment.Last())
                        group.Append(groupItem);
                    else group.Append(groupItem + ",");
                }
            }

            // Return group string.
            return ReturnBuildSegment(group.ToString());
        }
        /// <summary>
        /// Builds having segment to string.
        /// </summary>
        /// <returns>Having segment</returns>
        private string BuildHaving()
        {
            // Having string.
            StringBuilder having = new StringBuilder();

            // Append where statment.
            having.Append("HAVING ");

            // Query search condition.
            QuerySearchCondition querySearchCondition = new QuerySearchCondition(HavingSegment.AsEnumerable());

            // Append search condition.
            having.Append(querySearchCondition.ToString());

            // Return having string.
            return ReturnBuildSegment(having.ToString());
        }
        /// <summary>
        /// Builds offset segment to string.
        /// </summary>
        /// <returns>Offset segment</returns>
        private string BuildOffset()
        {
            string offset = "OFFSET " + Offset + " ROWS";
            return ReturnBuildSegment(offset);
        }
        /// <summary>
        /// Builds fetch segment to string.
        /// </summary>
        /// <returns>Fetch segment</returns>
        private string BuildFetch()
        {
            string fetch = "FETCH NEXT " + Fetch + " ROWS ONLY";
            return ReturnBuildSegment(fetch);
        }
        #endregion

        #region Main build
        /// <summary>
        /// Main entry point for query building.
        /// </summary>
        protected override void Build()
        {
            // Build select.
            if (SelectSegment.Any())
                Text = BuildSelect(); 

            // Build into.
            if (IntoSegment != null)
                Text += BuildInto();

            // Build update.
            if (UpdateSegment != null)
                Text = BuildUpdate();

            // Build set.
            if (SetColumnSegment.Any())
                Text += BuildSet();

            // Build insert.
            if (InsertSegment.Any())
                Text += BuildInsert();

            // Build delete.
            if (DeleteSegment.Any())
                Text = BuildDelete();

            // Build from.
            if (FromSegment != null)
                Text += BuildFrom();

            // Build join.
            if (JoinSegment.Any())
                Text += BuildJoin();

            // Build where.
            if (WhereSegment.Any())
                Text += BuildWhere();

            // Build group by.
            if (GroupSegment.Any() || AutoGroupBy)
                Text += BuildGroup();

            // Build having.
            if (HavingSegment.Any())
                Text += BuildHaving();

            // Build order by.
            if (OrderSegment.Any())
                Text += BuildOrder();

            // Build offset.
            if (Offset.HasValue)
                Text += BuildOffset();

            // Build fetch.
            if (Fetch.HasValue)
                Text += BuildFetch();
        }
        #endregion

        #region Execute
        /// <summary>
        /// Executes query.
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>Entity collection</returns>
        public IEnumerable<TEntity> GetEntityCollection<TEntity>() where TEntity : Entity, new()
        {
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create db command.
            var command = providerFactory.CreateCommand();

            // Set connection string.
            command.CommandText = this.ToString();

            // Set command.
            command.CommandText = ToString();

            // Execute and return entity collection.
            return EntityMechanic<TEntity>.GetByQueryCommand(command);
        }
        /// <summary>
        /// Executes query.
        /// </summary>
        /// <param name="objectMappingType">Object mapping type</param>
        /// <typeparam name="TObject">Non entity object type</typeparam>
        /// <returns>Non entity object collection</returns>
        public IEnumerable<TObject> GetObjectCollection<TObject>(ObjectMappingType objectMappingType = ObjectMappingType.Intersect) where TObject : class, new()
        {
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create db command.
            var command = providerFactory.CreateCommand();

            // Set connection string.
            command.CommandText = this.ToString();

            // Set command.
            command.CommandText = ToString();

            // Execute and return object collection.
            return ObjectMechanic<TObject>.GetByQueryCommand(command, objectMappingType);
        }
        /// <summary>
        /// Executes query.
        /// Experimenal, please do not use yet.
        /// </summary>
        /// <returns>Dynamic value collections</returns>
        public IEnumerable<dynamic> GetDynamicCollection()
        {
            // Create instance of return collection
            var objectCollection = new List<dynamic>();

            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (var connection = ambientContext.CreateConnection())
            {
                // Create db command.
                var command = providerFactory.CreateCommand();

                // Set command.
                command.CommandText = ToString();

                // Pass connection to command object.
                command.Connection = connection;

                // Open connection to database
                connection.Open();

                // Execute Sql data reader
                using (var dataReader = command.ExecuteReader())
                {
                    // Get property interface.
                    var names = Enumerable.Range(0, dataReader.FieldCount)
                        .Select(dataReader.GetName)
                        .ToList();

                    // Read data.
                    while (dataReader.Read())
                    {
                        // Create list object.
                        var @object = new ExpandoObject() as IDictionary<string, object>;

                        // Populate object.
                        foreach (var name in names)
                        {
                            @object[name] = dataReader[name];
                        }

                        // Add to collection.
                        objectCollection.Add(@object);
                    }
                }
            }

            // Return dictionary collection.
            return objectCollection;
        }
        /// <summary>
		/// Executes query.
		/// </summary>
		/// <returns>DataTable result</returns>
		public DataTable GetDataTable()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Executes query.
        /// </summary>
        /// <typeparam name="TScalar">Value type type.</typeparam>
        /// <returns>Scalar value.</returns>
        public TScalar GetScalar<TScalar>()
        {
			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider.
            var providerFactory = ambientContext.DbProviderFactory;

			// Create connection to database from ambient query context.
			using (DbConnection connection = ambientContext.CreateConnection())
			{
                // Create db command.
                var command = providerFactory.CreateCommand();

				// Set command.
				command.CommandText = this.ToString();

				// Pass connection to command object.
				command.Connection = connection;

				// Open connection to database
				connection.Open();

				// Get scalar value.
				object scalarValue = command.ExecuteScalar();
				if (scalarValue is System.DBNull)
					scalarValue = null;

				// Return scalar value.
				return (TScalar)scalarValue;
			}
        }
        /// <summary>
        /// Executes query.
        /// </summary>
        /// <returns>Query result container object.</returns>
        public QueryResult GetQueryResult()
        {
            // Build Query.
            Build();

            return null;
        }
		#endregion

		#region Execute async
		/// <summary>
		/// Executes query async.
		/// </summary>
		/// <param name="objectMappingType">Object mapping type</param>
		/// <typeparam name="TObject">Non entity object type</typeparam>
		/// <returns>Non entity object collection</returns>
		public async Task<IEnumerable<TObject>> GetObjectCollectionAsync<TObject>(ObjectMappingType objectMappingType = ObjectMappingType.Intersect) where TObject : class, new()
		{
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create db command.
            var command = providerFactory.CreateCommand();

            // Set connection string.
            command.CommandText = this.ToString();

            // Set command.
            command.CommandText = ToString();

            // Execute and return object collection.
            return await ObjectMechanic<TObject>.GetByQueryCommandAsync(command, objectMappingType);
		}
		/// <summary>
		/// Executes query async.
		/// </summary>
		/// <typeparam name="TEntity">Entity type</typeparam>
		/// <returns>Entity collection</returns>
		public async Task<IEnumerable<TEntity>> GetEntityCollectionAsync<TEntity>() where TEntity : Entity, new()
		{
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create db command.
            var command = providerFactory.CreateCommand();

            // Set connection string.
            command.CommandText = this.ToString();

            // Set command.
            command.CommandText = ToString();

            // Execute and return entity collection.
            return await EntityMechanic<TEntity>.GetByQueryCommandAsync(command);
		}
        /// <summary>
        /// Executes query.
        /// Experimenal, please do not use yet.
        /// </summary>
        /// <returns>Dynamic value collections</returns>
        public async Task<IEnumerable<dynamic>> GetDynamicCollectionAsync()
        {
            // Create instance of return collection
            var objectCollection = new List<dynamic>();

            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (var connection = ambientContext.CreateConnection())
            {
                // Create db command.
                var command = providerFactory.CreateCommand();

                // Set command.
                command.CommandText = ToString();

                // Pass connection to command object.
                command.Connection = connection;

                // Open connection to database
                await connection.OpenAsync();

                // Execute Sql data reader
                using (var dataReader = await command.ExecuteReaderAsync())
                {
                    // Get property interface.
                    var names = Enumerable.Range(0, dataReader.FieldCount)
                        .Select(dataReader.GetName)
                        .ToList();

                    // Read data.
                    while (await dataReader.ReadAsync())
                    {
                        // Create list object.
                        var @object = new ExpandoObject() as IDictionary<string, object>;

                        // Populate object.
                        foreach (var name in names)
						{
                            // Get oridinal.
                            var ordinal = dataReader.GetOrdinal(name);

                            // Get type.
                            var dbType = dataReader.GetDataTypeName(ordinal);

                            // Get value. (will not work with UDT types)
                            @object[name] = dataReader[name];
						}

                        // Add to collection.
                        objectCollection.Add(@object);
                    }
                }
            }

            // Return dictionary collection.
            return objectCollection;
        }
        /// <summary>
        /// Executes query.
        /// </summary>
        /// <typeparam name="TScalar">Value type type.</typeparam>
        /// <returns>Scalar value.</returns>
        public async Task<TScalar> GetScalarAsync<TScalar>()
		{
			// Get ambient query context.
			QueryContext ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (DbConnection connection = ambientContext.CreateConnection())
			{
                // Create db command.
                var command = providerFactory.CreateCommand();

				// Set command.
				command.CommandText = ToString();

				// Pass connection to command object.
				command.Connection = connection;

				// Open connection to database
				await connection.OpenAsync();

				// Get scalar value.
				object scalarValue = await command.ExecuteScalarAsync();
				if (scalarValue is System.DBNull)
					scalarValue = null;

				// Return scalar value.
				return (TScalar)scalarValue;
			}
		}
		#endregion

		#region Validation
		#endregion

		#region Helper methods
		/// <summary>
		/// Convert query operator to sql operator string.
		/// </summary>
		/// <param name="queryOperator">Query operator</param>
		/// <returns>Sql operator</returns>
		internal static string ToSqlOperator(QueryOp queryOperator)
        {
            // Convert operator.
            if (queryOperator == QueryOp.Equal) return " = ";
            else if (queryOperator == QueryOp.Greater) return " > ";
            else if (queryOperator == QueryOp.GreaterOrEqual) return " >= ";
            else if (queryOperator == QueryOp.In) return " IN ";
            else if (queryOperator == QueryOp.Is) return " IS ";
            else if (queryOperator == QueryOp.IsNot) return " IS NOT ";
            else if (queryOperator == QueryOp.Less) return " < ";
            else if (queryOperator == QueryOp.LessOrEqual) return " <= ";
            else if (queryOperator == QueryOp.Like) return " LIKE ";
            else if (queryOperator == QueryOp.NotEqual) return " != ";
            else if (queryOperator == QueryOp.NotIn) return " NOT IN ";
            else if (queryOperator == QueryOp.And) return "AND ";
            else if (queryOperator == QueryOp.Or) return "OR ";
            else if (queryOperator == QueryOp.Exists) return "EXISTS ";
            else if (queryOperator == QueryOp.NotExists) return "NOT EXISTS";
            else return "UNDEFINED_OPERATOR ";
        }
        /// <summary>
        /// Convert query join to sql join string.
        /// </summary>
        /// <param name="queryJoinType">Query join</param>
        /// <returns>Sql join</returns>
        internal static string ToSqlJoin(QueryJoinType queryJoinType)
        {
            if (queryJoinType == QueryJoinType.Inner) return "INNER JOIN ";
            else if (queryJoinType == QueryJoinType.Left) return "LEFT OUTER JOIN ";
            else if (queryJoinType == QueryJoinType.Right) return "RIGHT OUTER JOIN ";
            else if (queryJoinType == QueryJoinType.Full) return "FULL OUTER JOIN ";
            else if (queryJoinType == QueryJoinType.Cross) return "CROSS JOIN ";
            else return "UNDEFINED_JOIN ";
        }
        /// <summary>
        /// Returns formated or non formated build segment.
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        internal string ReturnBuildSegment(string segment, int newlineCount = 1)
        {
            // Build newline.
            string newline = string.Empty;
            for (int i = 0; i < newlineCount; i++)
                newline += Environment.NewLine;

            // Return select string.
            if (m_formatQueryText && string.IsNullOrWhiteSpace(segment) == false)
                return segment + newline;
            else return segment + " ";
        }
        #endregion
    }
}
