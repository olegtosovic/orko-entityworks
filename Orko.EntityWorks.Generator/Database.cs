using System;
using System.Collections.Concurrent;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Represents sql server database model object.
	/// Contains all database objects information required to generate entity classes.
	/// </summary>
	public class Database
    {
        #region Members
        /// <summary>
        /// Ensures syntax validity and database name existance in connection string.
        /// </summary>
        private DbConnectionStringBuilder m_stringBuilder;
        #endregion

        #region Methods
        /// <summary>
        /// Sets db provider specific factory.
        /// </summary>
        private void SetDbProvider()
		{
            // Get provider assembly.
            var providerAssembly = Assembly.Load(Options.DbProviderAssembly);

            // Get provider assembly.
            var providerType = providerAssembly.GetType(Options.DbProviderFactory);

            // Get provider instance.
            var providerInstance = providerType.GetField("Instance").GetValue(null);

            // Set db provider factory.
            this.DbProviderFactory = (DbProviderFactory)providerInstance;
        }
        /// <summary>
        /// Sets entity works generator specific provider.
        /// </summary>
        private void SetEwgProvider()
        {
            // Set ewg provider factory via db provider factory mapping.
            this.EwgProviderFactory = EwgProviderFactory.GetSpecificProvider(this.Options);
        }
        /// <summary>
        /// Loads database name.
        /// </summary>
        private void SetDatabaseName()
        {
            // Create connection builder from connection string.
            m_stringBuilder = DbProviderFactory.CreateConnectionStringBuilder();

            // Set connection string.
            m_stringBuilder.ConnectionString = ConnectionString;

            // Get database name from string.
            var databaseName = m_stringBuilder["Initial Catalog"] as string;

            // Check database name existance.
            if (string.IsNullOrWhiteSpace(databaseName))
                throw new EntityWorksGeneratorException("Connection string of database object does not have defined database name or initial catalog." +
                    "Please check your connection string or refer to documentation.");

            // Set database name.
            this.DatabaseName = databaseName;
        }
        /// <summary>
        /// If table has language table extend table with additional language table data.
        /// </summary>
        private void SetLanguageContext(Table languageTable)
        {
            // Get active options.
            var options = languageTable.Database.Options;

            // Assign theirs parents.
            string parentTableName = languageTable.SqlFullName.Replace(options.LanguageTableSuffix, string.Empty);
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
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        private Database()
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
            // Set db provider.
            // DbProviderFactory = dbProvider ?? throw new ArgumentNullException(nameof(dbProvider), "Db provider factory object can not be null.");

            // Set connection string.
            ConnectionString = !string.IsNullOrWhiteSpace(connectionString) ?
                connectionString : throw new ArgumentNullException(nameof(connectionString), "Connection string can not be null.");
        }
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        /// <param name="connectionString">Database connection string</param>
        /// <param name="options">Database generator options for this database</param>
        public Database(string connectionString, DatabaseGeneratorOptions options) : this(connectionString)
        {
            // Set entity works generator options.
            this.Options = options ?? throw new ArgumentNullException(nameof(options), "DatabaseGeneratorOptions can not be null.");

            // Set specific db provider factory.
            SetDbProvider();

            // Set database name.
            SetDatabaseName();

            // Set entity works generator specific provider.
            SetEwgProvider();
        }
        #endregion

        #region Provider properties
        /// <summary>
        /// EWG .NET provider for code generation logic.
        /// </summary>
        public EwgProviderFactory EwgProviderFactory { get; private set; }
        /// <summary>
        /// ADO .NET connectivity provider.
        /// </summary>
        public DbProviderFactory DbProviderFactory { get; private set; }
        #endregion

        #region General properties
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
        public DatabaseGeneratorOptions Options { get; private set; }
        /// <summary>
        /// Container that holds all database tables with table information.
        /// </summary>
        public ConcurrentDictionary<string, Table> Tables { get; private set; }
        #endregion

        #region State properties
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

        #region Meta properties
        public DataTable Columns { get; private set; }
        public DataTable PrimaryKeys { get; private set; }
        public DataTable ForeignKeys { get; private set; }
        public DataTable UniqueKeys { get; private set; }
        public DataTable Relations { get; private set; }
        public DataTable TableNames { get; set; }
        #endregion

        #region Main methods
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
            TableNames = new Sql(ConnectionString, DbProviderFactory).ExecuteSql(EwgProviderFactory.SqlProvider.TableNamesQuery);

            // Retrieve all columns from database.
            Columns = new Sql(ConnectionString, DbProviderFactory).ExecuteSql(EwgProviderFactory.SqlProvider.ColumnsQuery);

            // Retrieve all primary keys.
            PrimaryKeys = new Sql(ConnectionString, DbProviderFactory).ExecuteSql(EwgProviderFactory.SqlProvider.PrimaryKeysQuery);

            // Retrieve all foreign keys.
            ForeignKeys = new Sql(ConnectionString, DbProviderFactory).ExecuteSql(EwgProviderFactory.SqlProvider.ForeignKeysQuery);

            // Retrieve all unique keys.
            UniqueKeys = new Sql(ConnectionString, DbProviderFactory).ExecuteSql(EwgProviderFactory.SqlProvider.UniqueKeysQuery);

            // Retrieve all relations.
            Relations = new Sql(ConnectionString, DbProviderFactory).ExecuteSql(EwgProviderFactory.SqlProvider.ForeignKeyRelationsQuery);

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

            // Use parallel processing.
            if (this.Options.UseParallelProcessing) Parallel.ForEach(TableNames.AsEnumerable(), drTable => { CreateTableFromRow(drTable); });
            
            // Use non-parallel processing.
            else foreach (DataRow drTable in TableNames.Rows) { CreateTableFromRow(drTable); }
            
            // Assign language table relations to graph.
            if (this.Options.UseLanguageTables)
            {
                // Get all language tables.
                var languageTables = Tables.Values.Where(x => x.SqlName.EndsWith(this.Options.LanguageTableSuffix));

                // Use parallel processing.
                if (!this.Options.UseParallelProcessing) Parallel.ForEach(languageTables, languageTable => { SetLanguageContext(languageTable); });

                // Use non-parallel processing.
                else foreach (var languageTable in languageTables) { SetLanguageContext(languageTable); }           
            }

            // Mark as graphed and ready.
            IsGraphed = true;
            IsReady = true;
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
