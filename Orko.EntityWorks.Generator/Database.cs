using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    public class Database
    {
        #region Constructors
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        /// <param name="connectionString">Connection string</param>
        public Database(string connectionString)
        {
            // Assign properties.
            ConnectionString = connectionString;

            // Create instances.
            Tables = new ConcurrentDictionary<string, Table>();

            // Load datbase name.
            LoadDatabaseName();

            // Mark as not ready.
            IsReady = false;
        }
        /// <summary>
        /// Creates instance of database object.
        /// </summary>
        /// <param name="settings">Entity generator settings</param>
        /// <param name="connectionString">Connection string</param>
        /// <param name="prepare">Auto load database data and graph metadata</param>
        public Database(EntityGeneratorSettings settings, string connectionString, bool prepare = false)
        {
            // Create instances.
            Tables = new ConcurrentDictionary<string, Table>();

            // Assign properties.
            Settings = settings;
            ConnectionString = connectionString;

            // Prepare database.
            if (prepare)
            {
                // Load database name.
                LoadDatabaseName();

                // Load database data.
                LoadDatabaseData();

                // Load database graph.
                LoadDatabaseGraph();

                // Mark as ready.
                IsReady = true;
            }
        }
        #endregion

        #region Flags
        public bool IsReady { get; private set; }
        public bool IsLoaded { get; private set; }
        public bool IsGraphed { get; private set; }
        #endregion

        #region Properties
        public string DatabaseName { get; private set; }
        public string ConnectionString { get; private set; }
        public EntityGeneratorSettings Settings { get; set; }
        #endregion

        #region Metadata
        public DataTable Columns { get; private set; }
        public DataTable PrimaryKeys { get; private set; }
        public DataTable ForeignKeys { get; private set; }
        public DataTable UniqueKeys { get; private set; }
        public DataTable Relations { get; private set; }
        public DataTable TableNames { get; set; }
        #endregion

        #region Cache
        public ConcurrentDictionary<string, Table> Tables { get; private set; }
        #endregion

        #region Public methods
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
        public void LoadDatabaseGraph()
        {
            // If not loaded, notify error.
            if (!IsLoaded)
                throw new Exception("Can not load database graph, database metadata must be loaded.");

            // Use parallel processing.
            if (Settings.UseParallelProcessing) Parallel.ForEach(TableNames.AsEnumerable(), drTable => { CreateTableFromRow(drTable); });
            
            // Use non-parallel processing.
            else foreach (DataRow drTable in TableNames.Rows) { CreateTableFromRow(drTable); }
            
            // Assign language table relations to graph.
            if (Settings.UseLanguageTables)
            {
                // Get all language tables.
                var languageTables = Tables.Values.Where(x => x.Name.EndsWith(Settings.LanguageTableSuffix));

                // Use parallel processing.
                if (!Settings.UseParallelProcessing) Parallel.ForEach(languageTables, languageTable => { SetLanguageContext(languageTable); });

                // Use non-parallel processing.
                else foreach (var languageTable in languageTables) { SetLanguageContext(languageTable); }           
            }

            // Mark as graphed and ready.
            IsGraphed = true;
            IsReady = true;
        }
        #endregion

        #region Private methods
        private void LoadDatabaseName()
        {
            // Database name
            string databaseNameQuery = "SELECT DB_NAME() AS DatabaseName";
            DatabaseName = new Sql(ConnectionString).ExecuteSql(databaseNameQuery).Rows[0]["DatabaseName"].ToString();
        }
        private void SetLanguageContext(Table languageTable)
        {
            // Assign theirs parents.
            string parentTableName = languageTable.FullName.Replace(Settings.LanguageTableSuffix, string.Empty);
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
        private void CreateTableFromRow(DataRow tableRow)
        {
            string tableName = tableRow["table_name"].ToString();
            string schemaName = tableRow["table_schema_name"].ToString();
            string tableFullName = tableRow["table_fullname"].ToString();
            CreateTable(tableName, schemaName, tableFullName);
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
