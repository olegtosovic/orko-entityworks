using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Provides functionality for internal mechanics such as
	/// reading from database, mapping to entites and other operations.
	/// </summary>
	internal static class EntityMechanic<TEntity> where TEntity : Entity, new()
    {
        #region Constructors
        static EntityMechanic()
        {
            // Create entity context.
            EntityContext = new EntityContext<TEntity>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Entity context.
        /// </summary>
        public static EntityContext<TEntity> EntityContext { get; private set; }
        #endregion

        #region CRUD methods
        /// <summary>
        /// Gets single entity object for given primary key value.
        /// </summary>
        public static TEntity GetByPrimaryKey(params object[] parameters)
        {
            // Create TEntity reference;
            TEntity entity = null;

			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

			// Create connection to database from ambient query context.
			using (DbConnection connection = ambientContext.CreateConnection())
			{
                // Setup sql command
                var command = providerFactory.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = EntityContext.SelectString;
				command.Connection = connection;

                // Set sql command select parameters.
                SetSelectParameters(command, parameters);

				// Open connection to database
				connection.Open();

                // Execute Sql data reader
                using (var dataReader = command.ExecuteReader())
                {
                    // Create entity mapper.
                    var entityMapper = new EntityMapper<TEntity>();

                    // Read single row data.
                    while (dataReader.Read())
                    {
                        // Create entity instance.
                        entity = new TEntity();

                        // Map raw data to entity object.
                        entityMapper.MapToObject(entity, dataReader);

                        // Set entity status to not new.
                        entity.IsNew = false;
                    }
                }
            }

            // Return single TEntity entity. 
            return entity;
        }
        /// <summary>
        /// Gets single entity object for given unique key value.
        /// </summary>
        public static TEntity GetByUniqueKey(params object[] parameterValues)
        {
            // Get unique methods and parameters.
            //var getByUniqueMethod = new StackFrame(3).GetMethod();
            //var parameters = getByUniqueMethod.GetParameters();

            //// Generate query.
            //Query query = new Query();
            //query.Select(EntityContext.SqlPathPrefix + ".*");
            //query.From(EntityContext.SqlPathPrefix);
            //foreach (var parameter in parameters)
            //{
            //    var value = parameterValues.GetValue(parameter.Position);
            //    query.Where(parameter.Name, QueryOp.Equal, Query.Quote(value));
            //}
            //return query.GetSingle<TEntity>();

            return null;
        }
        /// <summary>
        /// Returns collection of entites given query conditions.
        /// </summary>
        public static IEnumerable<TEntity> GetByAny(params QueryCondition[] queryConditions)
        {
            // Create query.
            Query query = new Query();
            query.Select<TEntity>();
            query.From<TEntity>();
            query.From(EntityContext.SqlTablePathWithSchema);
            query.Where(queryConditions);

            // Return collection.
            return query.GetEntityCollection<TEntity>();
        }
        /// <summary>
        /// Returns collection of entites given query condition.
        /// </summary>
        public static IEnumerable<TEntity> GetByAny(string columnName, QueryOp queryOp, object value)
        {
            // Create query condition.
            QueryCondition queryCondition = new QueryCondition(columnName, queryOp, value);

            // Return collection.
            return GetByAny(queryCondition);
        }
        /// <summary>
        /// Get collection by sql command.
        /// </summary>
        public static IEnumerable<TEntity> GetByQueryCommand(DbCommand command)
        {
            // Create instance of return collection
            IList<TEntity> entityCollection = new List<TEntity>();

			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

			// Create connection to database from ambient query context.
			using (var connection = ambientContext.CreateConnection())
            {
                // Pass connection to command object.
                command.Connection = connection;

				// Open connection to database
				connection.Open();

                // Execute Sql data reader
                using (var dataReader = command.ExecuteReader())
                {
                    // Create entity mapper.
                    var entityMapper = new EntityMapper<TEntity>(ObjectMappingType.ModelFirst, dataReader);

                    // Read data.
                    while (dataReader.Read())
                    {
                        // Create new TEntity instance
                        var entity = new TEntity();

						// Map raw data to entity object
                        entityMapper.MapToObject(entity, dataReader);

                        // Add entity to collection
                        entityCollection.Add(entity);

                        // Set entity status to not new.
                        entity.IsNew = false;
                    }
                }
            }

            // Return object collection.
            return entityCollection;
        }
        /// <summary>
        /// Saves entity object to database.
        /// </summary>
        public static void SaveEntity(Entity entity)
        {
			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (var connection = ambientContext.CreateConnection())
            {
                var command = providerFactory.CreateCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                if (entity.IsNew)
                {
                    command.CommandText = EntityContext.InsertString;
                    SetParametersSaveEntity(command, entity);
					connection.Open();
                    command.ExecuteNonQuery();
                    GetOutputParametersSaveEntity(command, entity);
                    entity.IsNew = false;
                }
                else
                {
                    command.CommandText = EntityContext.UpdateString;
                    SetParametersUpdateEntity(command, entity);
					connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Deletes entity object from database.
        /// </summary>
        public static void DeleteEntity(Entity entity)
        {
			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (var connection = ambientContext.CreateConnection())
			{
                // If entity is new, it makes no sense to delete it from database so skip it.
                if (!entity.IsNew)
                {
                    var dbCommand = providerFactory.CreateCommand();
                    dbCommand.CommandType = CommandType.Text;
                    dbCommand.CommandText = EntityContext.DeleteString;
                    dbCommand.Connection = connection;
                    SetParametersDeleteEntity(dbCommand, entity);
					connection.Open();
                    dbCommand.ExecuteNonQuery();
                }
            }
        }
		#endregion

		#region CRUD methods async
		/// <summary>
		/// Gets single entity object for given primary key value async.
		/// </summary>
		public static async Task<TEntity> GetByPrimaryKeyAsync(params object[] parameters)
		{
			// Create TEntity reference;
			TEntity entity = null;

			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

			// Create connection to database from ambient query context.
			using (var connection = ambientContext.CreateConnection())
			{
				// Setup sql command
				var command = providerFactory.CreateCommand();
				command.CommandType = CommandType.Text;
				command.CommandText = EntityContext.SelectString;
				command.Connection = connection;

				// Set sql command select parameters.
				SetSelectParameters(command, parameters);

				// Open connection to database
				await connection.OpenAsync();

				// Execute Sql data reader
				using (var dataReader = await command.ExecuteReaderAsync())
				{
					// Create entity mapper.
					var entityMapper = new EntityMapper<TEntity>();

					// Read single row data.
					while (await dataReader.ReadAsync())
					{
						// Create entity instance.
						entity = new TEntity();

						// Map raw data to entity object.
						entityMapper.MapToObject(entity, dataReader);

						// Set entity status to not new.
						entity.IsNew = false;
					}
				}
			}

			// Return single TEntity entity. 
			return entity;
		}
		/// <summary>
		/// Gets single entity object for given unique key value async.
		/// </summary>
		public static async Task<TEntity> GetByUniqueKeyAsync(params object[] parameterValues)
		{
			return await Task.FromResult<TEntity>(null);
		}
		/// <summary>
		/// Returns collection of entites given query conditions async.
		/// </summary>
		public static async Task<IEnumerable<TEntity>> GetByAnyAsync(params QueryCondition[] queryConditions)
		{
			// Create query.
			Query query = new Query();
			query.Select<TEntity>();
			query.From<TEntity>();
			//query.From(EntityContext.SqlPathPrefix);
			query.Where(queryConditions);

			// Return collection.
			return await query.GetEntityCollectionAsync<TEntity>();
		}
		/// <summary>
		/// Returns collection of entites given query condition async.
		/// </summary>
		public static async Task<IEnumerable<TEntity>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
		{
			// Create query condition.
			QueryCondition queryCondition = new QueryCondition(columnName, queryOp, value);

			// Return collection.
			return await GetByAnyAsync(queryCondition);
		}
		/// <summary>
		/// Get collection by sql command async.
		/// </summary>
		public static async Task<IEnumerable<TEntity>> GetByQueryCommandAsync(DbCommand command)
		{
			// Create instance of return collection
			var entityCollection = new List<TEntity>();

			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

			// Create connection to database from ambient query context.
			using (var connection = ambientContext.CreateConnection())
			{
				// Pass connection to command object.
				command.Connection = connection;

				// Open connection to database
				await connection.OpenAsync();

				// Execute Sql data reader
				using (var dataReader = await command.ExecuteReaderAsync())
				{
					// Create entity mapper.
					var entityMapper = new EntityMapper<TEntity>(ObjectMappingType.ModelFirst, dataReader);

					// Read data.
					while (await dataReader.ReadAsync())
					{
						// Create new TEntity instance
						var entity = new TEntity();

						// Map raw data to entity object
						entityMapper.MapToObject(entity, dataReader);

						// Add entity to collection
						entityCollection.Add(entity);

						// Set entity status to not new.
						entity.IsNew = false;
					}
				}
			}

			// Return object collection.
			return entityCollection;
		}
		/// <summary>
		/// Saves entity object to database async.
		/// </summary>
		public static async Task SaveEntityAsync(Entity entity)
		{
			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (DbConnection connection = ambientContext.CreateConnection())
			{
				DbCommand command = providerFactory.CreateCommand();
				command.CommandType = CommandType.Text;
				command.Connection = connection;

				if (entity.IsNew)
				{
					command.CommandText = EntityContext.InsertString;
					SetParametersSaveEntity(command, entity);
					await connection.OpenAsync();
					await command.ExecuteNonQueryAsync();
					GetOutputParametersSaveEntity(command, entity);
					entity.IsNew = false;
				}
				else
				{
					command.CommandText = EntityContext.UpdateString;
					SetParametersUpdateEntity(command, entity);
					await connection.OpenAsync();
					await command.ExecuteNonQueryAsync();
				}
			}
		}
		/// <summary>
		/// Deletes entity object from database async.
		/// </summary>
		public static async Task DeleteEntityAsync(Entity entity)
		{
			// Get ambient query context.
			var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Create connection to database from ambient query context.
            using (var connection = ambientContext.CreateConnection())
			{
				// If entity is new, it makes no sense to delete it from database so skip it.
				if (!entity.IsNew)
				{
					var dbCommand = providerFactory.CreateCommand();
                    dbCommand.CommandType = CommandType.Text;
                    dbCommand.CommandText = EntityContext.DeleteString;
                    dbCommand.Connection = connection;
					SetParametersDeleteEntity(dbCommand, entity);
					await connection.OpenAsync();
					await dbCommand.ExecuteNonQueryAsync();
				}
			}
		}
		#endregion

		#region CRUD parameters setup
		/// <summary>
		/// Sets primary key parameters for IDbCommand query.
		/// </summary>
		private static void SetSelectParameters(DbCommand command, params object[] parameters)
        {
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Set sql command parameters.
            for (int i = 0; i < EntityContext.PrimaryKeyParameters.Count; i++)
            {
                object value = parameters[i];
                if (value == null) value = DBNull.Value;
                var sqlParameter = providerFactory.CreateParameter();
                sqlParameter.ParameterName = EntityContext.PrimaryKeyParameters[i].ParameterName;
                sqlParameter.DbType = EntityContext.PrimaryKeyParameters[i].SqlDbType;
                sqlParameter.Value = value;
                command.Parameters.Add(sqlParameter);
            }

            // Set language code parameter.
            if (EntityContext.HasLanguageTable)
            {
                //object value = EntityWorks.LanguageCode;
                object value = QueryContext.GetAmbientQueryContext().LanguageCode;
				if (value == null) value = DBNull.Value;
                var sqlParameter = providerFactory.CreateParameter();
                sqlParameter.ParameterName = EntityContext.LanguageCodeParameter.ParameterName;
                sqlParameter.DbType = EntityContext.LanguageCodeParameter.SqlDbType;
                sqlParameter.Value = value;
                command.Parameters.Add(sqlParameter);
            }
        }
        /// <summary>
        /// Sets all parameters for IDbCommand query.
        /// </summary>
        private static void SetParametersSaveEntity(DbCommand command, Entity entity)
        {
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Set sql command parameters
            foreach (var property in EntityContext.Properties.Values.Where(x => !x.IsForeignKey))
			{
				if (property.IsTimestamp) { continue; }
				var parameter = EntityContext.Parameters[property.PropertyName];
                var sqlParameter = providerFactory.CreateParameter();
                sqlParameter.ParameterName = parameter.ParameterNameWithMonkey;
                sqlParameter.DbType = parameter.SqlDbType;

                object value = null;
                if (property.IsLanguageCode)
                {
                    //value = QueryContext.Current.LanguageCode;
					value = QueryContext.GetAmbientQueryContext().LanguageCode;
					property.SetValue(value, (TEntity)entity);
                }
                else value = property.GetValue((TEntity)entity);
                if (value == null) value = DBNull.Value;
                sqlParameter.Value = value;

                if (property.IsIdentity) { sqlParameter.Direction = ParameterDirection.Output; }
                else { sqlParameter.Direction = ParameterDirection.Input; }

                command.Parameters.Add(sqlParameter);
            }
        }
        /// <summary>
        /// Sets all parameters for IDbCommand query.
        /// </summary>
        private static void SetParametersUpdateEntity(DbCommand command, Entity entity)
        {
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Set sql command parameters
            foreach (var property in EntityContext.Properties.Values.Where(x => !x.IsForeignKey))
            {
				if (property.IsTimestamp) { continue; }

				Parameter parameter = EntityContext.Parameters[property.PropertyName];
                var sqlParameter = providerFactory.CreateParameter();
                sqlParameter.ParameterName = parameter.ParameterNameWithMonkey;
                sqlParameter.DbType = parameter.SqlDbType;
                sqlParameter.Value = property.GetValue((TEntity)entity);
                sqlParameter.Direction = ParameterDirection.Input;

				command.Parameters.Add(sqlParameter);
            }
        }
        /// <summary>
        /// Sets primary key parameters for IDbCommand query.
        /// </summary>
        private static void SetParametersDeleteEntity(DbCommand command, Entity entity)
        {
            // Get ambient query context.
            var ambientContext = QueryContext.GetAmbientQueryContext();

            // Get provider factory.
            var providerFactory = ambientContext.DbProviderFactory;

            // Set sql command parameters
            foreach (var parameter in EntityContext.PrimaryKeyParameters)
            {
                var property = EntityContext.Properties[parameter.ParameterName];
                var sqlParameter = providerFactory.CreateParameter();
                sqlParameter.ParameterName = parameter.ParameterNameWithMonkey;
                sqlParameter.DbType = parameter.SqlDbType;
                sqlParameter.Value = property.GetValue((TEntity)entity);
                sqlParameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(sqlParameter);
            }

            // Set language code parameter.
            if (EntityContext.HasLanguageTable)
            {
                var property = EntityContext.Properties[EntityContext.LanguageCodeParameter.ParameterName];
                var sqlParameter = providerFactory.CreateParameter();
                sqlParameter.ParameterName = EntityContext.LanguageCodeParameter.ParameterName;
                sqlParameter.DbType = EntityContext.LanguageCodeParameter.SqlDbType;
                sqlParameter.Value = property.GetValue((TEntity)entity);
                command.Parameters.Add(sqlParameter);
            }
        }
        /// <summary>
        /// Return output parameters to IDbCommand.
        /// </summary>
        private static void GetOutputParametersSaveEntity(DbCommand command, Entity entity)
        {
            // Set sql command parameters
            foreach (var property in EntityContext.Properties.Values.Where(x => x.IsIdentity && !x.IsTimestamp))
            {
                Parameter parameter = EntityContext.Parameters[property.PropertyName];
                var sqlParameter = (DbParameter)command.Parameters[parameter.ParameterNameWithMonkey];
                object propertyValue = sqlParameter.Value;
                property.SetValue(propertyValue, (TEntity)entity);
            }
        }
		#endregion

		#region Required validation
		/// <summary>
		/// Validates entity against database constraints.
		/// </summary>
		public static void ValidateEntity(Entity entity)
		{
			// For each property value check constraint.
			foreach (var property in EntityContext.RequiredProperties)
			{
				var value = property.GetValue((TEntity)entity);
				if (value == null)
					throw new Exception("Column [" + property.PropertyName + "] is required for input");
			}
		}
		#endregion

		#region Property accessor
		/// <summary>
		/// Gets property primary key parameter values from declaring entity. 
		/// </summary>
		/// <typeparam name="TParent">Declaring entity type</typeparam>
		/// <param name="childEntity">Property object</param>
		/// <param name="parentEntity">Declaring entity object</param>
		/// <param name="propertyName">Property name</param>
		internal static object[] GetPrimaryKeyParameters<TParent>(TEntity childEntity, TParent parentEntity, string propertyName) where TParent : Entity, new()
        {
            // Get entity context object which has child property.
            EntityContext<TParent> entityContextTParent = EntityContext<TParent>.GetEntityContext();

            // Get child entity property entity context.
            EntityContext<TEntity> entityContextTEntity = EntityContext;

            // Get TEntity property.
            var property = entityContextTParent.Properties[propertyName];

            // Initialize parameters object;
            object[] parameters = new object[entityContextTEntity.PrimaryKeyParameters.Count];

            int i = 0;
            foreach (var relation in property.Relations)
            {
                var propertyTparent = entityContextTParent.Properties[relation.Value];
                object propertyValueTparent = propertyTparent.GetValue(parentEntity);
                parameters[i] = propertyValueTparent;
                i++;
            }
            return parameters;
        }
        /// <summary>
        /// Sets property primary key parameter values from declaring entity. 
        /// </summary>
        /// <typeparam name="TParent">Declaring entity type</typeparam>
        /// <param name="parentEntity">Declaring entity object</param>
        /// <param name="valueEntity">Property member object</param>
        /// <param name="propertyName">Property name</param>
        internal static void SetPrimaryKeyParameters<TParent>(TParent parentEntity, TEntity valueEntity, string propertyName) where TParent : Entity, new()
        {
            // Get entity context object which has child property.
            EntityContext<TParent> entityContextTParent = EntityContext<TParent>.GetEntityContext();

            // Get value entity property entity context.
            EntityContext<TEntity> entityContextTEntity = EntityContext;

            // Get Tobject property.
            var property = entityContextTParent.Properties[propertyName];

            // For every property field map value to parent relation field.
            foreach (var relation in property.Relations)
            {
                var propertyTobject = entityContextTEntity.Properties[relation.Key];
                var propertyTparent = entityContextTParent.Properties[relation.Value];

                object propertyValueTobject = propertyTobject.GetValue(valueEntity);
                propertyTparent.SetValue(propertyValueTobject, parentEntity);
            }
        }
		#endregion

		#region Clone
        /// <summary>
        /// Return a new copy of source entity object.
        /// </summary>
        public static TEntity Clone(TEntity sourceEntity)
		{
            // Create new entity.
            var copy = new TEntity();

            // Create new entity mapper.
            var entityMapper = new EntityMapper<TEntity>();

            // Map properties to source entity.
            entityMapper.MapToObject(copy, sourceEntity);

            // Set state.
            copy.IsNew = true;

            // Return new copy.
            return copy;
		}
		#endregion
	}
}
