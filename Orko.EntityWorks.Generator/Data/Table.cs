using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    public sealed class Table
    {
        #region Constructors
        public Table(string tableName, string schemaName, string tableFullname, Database database)
        {
            // Assign properties.
            Name = tableName;
            FullName = tableFullname;
            Schema = schemaName;
            Database = database;

            // Create instances.
            CreateInstances();

            // Load keys and columns.
            CacheColumns();
            LoadPrimaryKey();
            LoadUniqueKeys();
            LoadForeignKeys();
            LoadColumns();
        }
        #endregion

        #region Data
        public ConcurrentBag<DataRow> ColumnRows { get; private set; }
        #endregion

        #region Properties
        public string Name { get; private set; }
        public string Schema { get; private set; }
        public string FullName { get; private set; }
        public bool IsLanguageTable { get; set; }
        public bool HasLanguageTable { get; set; }
        public Table LanguageTable { get; set; }
        public PrimaryKey PrimaryKey { get; private set; }
        public ConcurrentDictionary<string, ForeignKey> ForeignKeys { get; private set; }
        public ConcurrentDictionary<string, UniqueKey> UniqueKeys { get; private set; }
        public ConcurrentDictionary<string, Column> Columns { get; private set; }
        public Database Database { get; private set; }
        public bool Ready { get; private set; }
        #endregion

        #region Methods
        public Column CreateColumn(string columnName, bool isPartOfprimaryKey = false, bool isPartOfUniqueKey = false)
        {
            return Columns.GetOrAdd(
                columnName,
                column => { return new Column(columnName, this, isPartOfprimaryKey, isPartOfUniqueKey); }
                );
        }
        private void LoadPrimaryKey()
        {
            // Load primary key.
            PrimaryKey = new PrimaryKey(this);
        }
        private void CreateInstances()
        {
            ForeignKeys = new ConcurrentDictionary<string, ForeignKey>();
            UniqueKeys = new ConcurrentDictionary<string, UniqueKey>();
            Columns = new ConcurrentDictionary<string, Column>();
            ColumnRows = new ConcurrentBag<DataRow>();
        }
        private void LoadColumns()
        {
            foreach (DataRow tableColumn in ColumnRows)
            {
                Column column = new Column(tableColumn, this);
            }
        }
        private void CacheColumns()
        {
            // Cache column rows.
            Database.Columns.AsEnumerable()
                .Where(
                    column => column.Field<string>("table_name") == Name &&
                    column.Field<string>("table_schema_name") == Schema
                )
                .ToList()
                .ForEach(column => ColumnRows.Add(column));
        }
        private void LoadUniqueKeys()
        {
            // Get foreign keys for table in context.
            var tableUniqueKeys = Database.UniqueKeys.AsEnumerable()
                .Where(
                    uniqueKey => uniqueKey.Field<string>("table_name") == Name &&
                    uniqueKey.Field<string>("table_schema_name") == Schema
                ).ToList();

            // If none, return.
            if (tableUniqueKeys.Any() == false)
                return;

            // Group uniqe key name/columns pair.
            var uniqueGroup = tableUniqueKeys
                .GroupBy(x => x.Field<string>("unique_key_name"))
                .ToDictionary(g => g.Key, g => g.Select(x => x));
            
            // For each group load key.
            foreach(var group in uniqueGroup)
            {
                var uniqueColumns = group.Value;
                UniqueKey uniqueKey = new UniqueKey(uniqueColumns, this);
                UniqueKeys.GetOrAdd(uniqueKey.Name, uniqueKey);
            }
        }
        private void LoadForeignKeys()
        {
            // Get foreign keys for table in context.
            var tableForeignKeys = Database.ForeignKeys.AsEnumerable()
                .Where(
                    foreignKey => foreignKey.Field<string>("table_name") == Name &&
                    foreignKey.Field<string>("table_schema_name") == Schema
                ).ToList();

            // If none, return.
            if (tableForeignKeys.Any() == false)
                return;

            // Create foreign keys.
            foreach (var tableForeignKey in tableForeignKeys)
            {
                string foreign_key_name = tableForeignKey["foreign_key_name"].ToString();
                ForeignKey foreignKey = new ForeignKey(tableForeignKey, this);
                ForeignKeys.GetOrAdd(foreign_key_name, foreignKey);
            }
        }
        #endregion
    }
}
