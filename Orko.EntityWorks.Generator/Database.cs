using Microsoft.Data.SqlClient;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Represents sql server database object.
	/// Contains all database objects information required to generate entity classes.
    /// Both generator and database object contain entityworks generator options.
    /// If database options exists, they will override generator global options.
	/// </summary>
	public class Database
    {
        #region Members
        /// <summary>
        /// Ensures syntax validity and database name existance in connection string.
        /// </summary>
        private SqlConnectionStringBuilder m_stringBuilder;
		#endregion

		#region Private methods
		/// <summary>
		/// Loads database name.
		/// </summary>
		private void SetDatabaseName()
        {
            // Create connection builder from connection string.
            m_stringBuilder = new SqlConnectionStringBuilder(this.ConnectionString);

            // Check database name existance.
            if (string.IsNullOrWhiteSpace(m_stringBuilder.InitialCatalog))
                throw new EntityWorksGeneratorException("Connection string of database object does not have defined database name or initial catalog." +
                    "Please refer to documentation.");

            // Set database name.
            this.DatabaseName = m_stringBuilder.InitialCatalog;
        }
        /// <summary>
        /// If table has language table extend table with additional language table data.
        /// </summary>
        private void SetLanguageContext(Table languageTable)
        {
            // Get active options.
            var options = GetActiveEntityWorksGeneratorOptions();

            // Assign theirs parents.
            string parentTableName = languageTable.FullName.Replace(options.LanguageTableSuffix, string.Empty);
            Table parentTable = null;
            if (Tables.TryGetValue(parentTableName, out parentTable))
            {
                parentTable.LanguageTable = languageTable;
                parentTable.HasLanguageTable = true;
                parentTable.LanguageTable.IsLanguageTable = true;
            }

            // If parent table does not exist stop.
            if (parentTable == null)
                return;

            // Assign language column metadata.
            var tableColumns = parentTable.Columns.Values.AsEnumerable();
            var tablePKColumns = parentTable.PrimaryKey.Columns.Values.AsEnumerable();
            var langTableColumns = languageTable.Columns.Values.AsEnumerable();
            var langTablePKColumns = languageTable.PrimaryKey.Columns.Values.AsEnumerable();

            // Diffrence language code.
            var languageCodeColumns = langTablePKColumns.Except(tablePKColumns, new ColumnEqualityComparer());
            var languageCodeColumn = languageCodeColumns.First();
            languageCodeColumn.IsLanguageCode = true;

            // Diffrence all other columns.
            var plainColumns = langTableColumns.Except(langTablePKColumns).AsEnumerable();
            foreach (var column in plainColumns) column.IsLanguage = true;

        }
        /// <summary>
        /// Created table object from raw data row object representing table.
        /// </summary>
        private void CreateTableFromRow(DataRow tableRow)
        {
            string tableName = tableRow["table_name"].ToString();
            string schemaName = tableRow["table_schema_name"].ToString();
            string tableFullName = tableRow["table_fullname"].ToString();
            CreateTable(tableName, schemaName, tableFullName);
        }
        /// <summary>
        /// Gets specific database entity works generator options, if null than get global options.
        /// </summary>
        internal EntityWorksGeneratorOptions GetActiveEntityWorksGeneratorOptions()
        {
            // Get and validate options.
            var options = this.Options ?? this.Generator.Options;
            if (options == null)
                throw new EntityWorksGeneratorException("Database object has no active entity works options. " +
                    "Please set either global entity works configuration options or specific options for database object." +
                    "For more details please refer to documentation.");

            // Return options.
            return this.Options ?? this.Generator.Options;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        public Database()
        {
            // Create instances.
            Tables = new ConcurrentDictionary<string, Table>();

            // Mark as not ready.
            IsReady = false;
        }
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        public Database(string connectionString) : this()
        {
            // Set properties.
            ConnectionString = connectionString;

            // Set database name.
            SetDatabaseName();

            // Mark as not ready.
            IsReady = false;
        }
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        /// <param name="options">Entity generator options for this database</param>
        /// <param name="prepare">Immediately load database name, data and graph metadata</param>
        public Database(string connectionString, EntityWorksGeneratorOptions options, bool prepare = false) : this(connectionString)
        {
            // Set properties.
            Options = options;
            ConnectionString = connectionString;

            // Prepare database.
            if (prepare)
                Prepare();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Sql server's database name.
        /// </summary>
        public string DatabaseName { get; private set; }
        /// <summary>
        /// Sql Server's connection string.
        /// </summary>
        public string ConnectionString { get; private set; }
        /// <summary>
        /// Entity works options for this database.
        /// </summary>
        public EntityWorksGeneratorOptions Options { get; private set; }
		#endregion

		#region Generator
        /// <summary>
        /// Entity works generator.
        /// </summary>
		public EntityWorksGenerator Generator { get; internal set; }
        #endregion

		#region State flags
		/// <summary>
		/// Indicated if database is ready for generation.
		/// </summary>
		public bool IsReady { get; private set; }
        /// <summary>
        /// Indicates if database raw data is loaded from server.
        /// </summary>
        public bool IsLoaded { get; private set; }
        /// <summary>
        /// Indicates if database raw data is structured and ready for generation.
        /// </summary>
        public bool IsGraphed { get; private set; }
        #endregion

        #region Metadata
        public DataTable Columns { get; private set; }
        public DataTable PrimaryKeys { get; private set; }
        public DataTable ForeignKeys { get; private set; }
        public DataTable UniqueKeys { get; private set; }
        public DataTable Relations { get; private set; }
        public DataTable TableNames { get; set; }
        #endregion

        #region Thread safe caching
        public ConcurrentDictionary<string, Table> Tables { get; private set; }
        #endregion

        #region Main public methods
        /// <summary>
        /// Load all database data and metadata.
        /// </summary>
        public void Prepare()
		{
            // Load database name.
            SetDatabaseName();

            // Load database data.
            LoadDatabaseData();

            // Load database graph.
            LoadDatabaseGraph();

            // Mark as ready.
            IsReady = true;
        }
        /// <summary>
        /// Loads all database data.
        /// </summary>
        public void LoadDatabaseData()
        {
            // Retrieve all table names from database created by user query.
            string tableNamesQuery =
                "SELECT SCHEMA_NAME(t.schema_id) table_schema_name, "+
                "COUNT(fkeys.object_id) foreign_keys_count, " +
                "SCHEMA_NAME(t.schema_id) + '.' + t.name table_fullname, " +
                "t.name AS table_name FROM sys.tables t " +
                "LEFT JOIN sys.extended_properties ep " +
                "ON ep.major_id = t.object_id " +
                "AND ep.name = 'microsoft_database_tools_support' " +
                "AND ep.class_desc = 'OBJECT_OR_COLUMN' " +
                "LEFT JOIN sys.foreign_keys fkeys " +
                "ON fkeys.parent_object_id = t.object_id " +
                "WHERE t.is_ms_shipped = 0 " +
                "AND OBJECTPROPERTY(t.object_id,'TableHasPrimaryKey') = 1 " +
                "AND ep.major_id IS NULL " +
                "GROUP BY SCHEMA_NAME(t.schema_id), t.name " +
                "ORDER BY COUNT(fkeys.object_id) DESC;";
            TableNames = new Sql(ConnectionString).ExecuteSql(tableNamesQuery);

            // Retrieve all columns from database.
            string columnsQuery =
                "SELECT sys.columns.name column_name, " +
                "sys.columns.column_id column_id, " +
                "SCHEMA_NAME(t.schema_id) table_schema_name, " +
                "OBJECT_NAME(sys.columns.object_id) table_name, " +
                "COLUMNPROPERTY(sys.columns.object_id, sys.columns.name, 'charmaxlen') max_characters, " +
                "TYPE_NAME(user_type_id) sql_data_type, " +
                "is_identity, " +
                "is_nullable FROM sys.columns " +
                "inner join sys.tables t on t.object_id = sys.columns.object_id " +
                "LEFT JOIN sys.extended_properties ep " +
                "ON ep.major_id = t.object_id " +
                "AND ep.name = 'microsoft_database_tools_support' " +
                "AND ep.class_desc = 'OBJECT_OR_COLUMN' " +
                "WHERE t.is_ms_shipped = 0 " +
                "AND OBJECTPROPERTY(t.object_id, 'TableHasPrimaryKey') = 1 " +
                "AND ep.major_id IS NULL " +
                "ORDER BY table_schema_name ASC, table_name ASC, column_id ASC;";
            Columns = new Sql(ConnectionString).ExecuteSql(columnsQuery);

            // Retrieve all primary keys.
            string primaryKeysQuery =
                "SELECT c.name column_name, i.name primarykey_name, " +
                "SCHEMA_NAME(t.schema_id) table_schema_name, " + 
                "OBJECT_NAME(i.object_id) table_name " +
                "FROM sys.indexes AS i " +
                "INNER JOIN sys.index_columns AS ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id " +
                "INNER JOIN sys.columns AS c ON ic.object_id = c.object_id AND c.column_id = ic.column_id " +
                "INNER JOIN sys.tables t ON ic.object_id = t.object_id  " +
                "WHERE i.is_primary_key = 1; ";
            PrimaryKeys = new Sql(ConnectionString).ExecuteSql(primaryKeysQuery);

            // Retrieve all foreign keys.
            string foreignKeysQuery =
                "SELECT DISTINCT OBJECT_NAME(fkeys.object_id) AS foreign_key_name, " +
                "SCHEMA_NAME(tbls.schema_id) table_schema_name,  " +
                "OBJECT_NAME(fkeys.parent_object_id) table_name " +
                "FROM sys.foreign_keys fkeys " +
                "INNER JOIN sys.foreign_key_columns fkeyc ON fkeys.object_id = fkeyc.constraint_object_id " +
                "INNER JOIN sys.tables tbls ON tbls.object_id = fkeys.parent_object_id " +
                "ORDER BY 1 ASC";
            ForeignKeys = new Sql(ConnectionString).ExecuteSql(foreignKeysQuery);

            // Retrieve all unique keys.
            string uniqueKeysQuery =
                "SELECT SCHEMA_NAME(t.schema_id) table_schema_name, " +
                "OBJECT_NAME(si.object_id) table_name, " +
                "si.name unique_key_name, " +
                "COL_NAME(t.object_id, ic.column_id) column_name " +
                "FROM sys.indexes si " +
                "INNER JOIN sys.index_columns ic on ic.object_id = si.object_id and ic.index_id = si.index_id " +
                "INNER JOIN sys.tables t on t.object_id = si.object_id " +
                "LEFT JOIN sys.extended_properties ep " +
                "ON ep.major_id = t.object_id " +
                "AND ep.name = 'microsoft_database_tools_support' " +
                "AND ep.class_desc = 'OBJECT_OR_COLUMN' " +
                "WHERE t.is_ms_shipped = 0 " +
                "AND OBJECTPROPERTY(t.object_id, 'TableHasPrimaryKey') = 1 " +
                "AND ep.major_id IS NULL " +
                "AND si.is_unique_constraint = 1 " +
                "ORDER BY 1 ASC, 2 ASC; ";
            UniqueKeys = new Sql(ConnectionString).ExecuteSql(uniqueKeysQuery);

            // Retrieve all relations.
            string relationsQuery =
                "SELECT OBJECT_NAME(fkeys.object_id) AS foreign_key_name, " +
                "OBJECT_NAME(fkeys.parent_object_id) AS foreign_key_table, " +
                "SCHEMA_NAME(fk_table.schema_id) AS foreign_key_table_schema, " +
                "(SCHEMA_NAME(fk_table.schema_id) + '.' + OBJECT_NAME(fkeys.parent_object_id)) foreign_key_table_fullname, " +
                "COL_NAME(fkeyc.parent_object_id, fkeyc.parent_column_id) AS foreign_key_column, " +
                "OBJECT_NAME(fkeys.referenced_object_id) AS primary_key_table, " +
                "SCHEMA_NAME(pk_table.schema_id) AS primary_key_table_schema, " +
                "(SCHEMA_NAME(pk_table.schema_id) + '.' + OBJECT_NAME(fkeys.referenced_object_id)) primary_key_table_fullname, " +
                "COL_NAME(fkeyc.referenced_object_id,fkeyc.referenced_column_id) primary_key_column " +
                "FROM sys.foreign_keys fkeys " +
                "INNER JOIN sys.foreign_key_columns fkeyc ON fkeys.object_id = fkeyc.constraint_object_id " +
                "INNER JOIN sys.tables fk_table ON fk_table.object_id = fkeys.parent_object_id " +
                "INNER JOIN sys.tables pk_table ON pk_table.object_id = fkeys.referenced_object_id " +
                "LEFT JOIN sys.extended_properties ep " +
                "ON ep.major_id = fk_table.object_id " +
                "AND ep.name = 'microsoft_database_tools_support' " +
                "AND ep.class_desc = 'OBJECT_OR_COLUMN' " +
                "WHERE fk_table.is_ms_shipped = 0 " +
                "AND OBJECTPROPERTY(fk_table.object_id, 'TableHasPrimaryKey') = 1 " +
                "AND ep.major_id IS NULL ";
            Relations = new Sql(ConnectionString).ExecuteSql(relationsQuery);

            // Mark as loaded.
            IsLoaded = true;
        }
        /// <summary>
        /// Loads all database graph data.
        /// </summary>
        public void LoadDatabaseGraph()
        {
            // If not loaded, notify error.
            if (!IsLoaded)
                throw new Exception("Can not load database graph, database metadata must be loaded.");

            // Get active options.
            var options = GetActiveEntityWorksGeneratorOptions();

            // Use parallel processing.
            if (options.UseParallelProcessing) Parallel.ForEach(TableNames.AsEnumerable(), drTable => { CreateTableFromRow(drTable); });
            
            // Use non-parallel processing.
            else foreach (DataRow drTable in TableNames.Rows) { CreateTableFromRow(drTable); }
            
            // Assign language table relations to graph.
            if (options.UseLanguageTables)
            {
                // Get all language tables.
                var languageTables = Tables.Values.Where(x => x.Name.EndsWith(options.LanguageTableSuffix));

                // Use parallel processing.
                if (!options.UseParallelProcessing) Parallel.ForEach(languageTables, languageTable => { SetLanguageContext(languageTable); });

                // Use non-parallel processing.
                else foreach (var languageTable in languageTables) { SetLanguageContext(languageTable); }           
            }

            // Mark as graphed and ready.
            IsGraphed = true;
            IsReady = true;
        }        
        #endregion

        #region Assigment public methods
        /// <summary>
        /// Sets specific entity works generator options.
        /// </summary>
        public void SetEntityWorksGeneratorOptions(EntityWorksGeneratorOptions options)
        {
            // Validation options instance.
            if (options == null)
                throw new ArgumentNullException(nameof(options), "EntityWorksGeneratorOptions can not be null.");

            // Set database specific options.
            this.Options = options;
        }
        #endregion

        #region Helper methods
        public Table CreateTable(string tableName, string schemaName, string tableFullname)
        {
            // Get or create table from cache.
            return Tables.GetOrAdd(tableFullname, x => { return new Table(tableName, schemaName, tableFullname, this); });
        }
        #endregion
    }
}
