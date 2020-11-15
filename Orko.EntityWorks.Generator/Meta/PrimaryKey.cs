using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Collections.Concurrent;

namespace Orko.EntityWorks.Generator
{
    public class PrimaryKey
    {
        #region Constructors
        public PrimaryKey(Table table)
        {
            // Initialization
            Table = table;
            Columns = new Dictionary<string, Column>();

            // Retrieve primary key columns from data cache.
            var primaryKeyColumns = table.Database.PrimaryKeys.AsEnumerable()
                .Where (
                    pKeyColumn => pKeyColumn.Field<string>("table_name") == table.Name &&
                    pKeyColumn.Field<string>("table_schema_name") == table.Schema)
                .ToList();

            Name = primaryKeyColumns.First()["primarykey_name"].ToString();
            foreach (DataRow primaryKeyColumn in primaryKeyColumns)
            {
                string columnName = primaryKeyColumn["column_name"].ToString();
                Column column = table.CreateColumn(columnName, isPartOfprimaryKey: true);
                Columns.Add(columnName, column);
            }
        }
        #endregion

        #region Properties
        public string Name { get; private set; }
        public Table Table { get; private set; }
        public Dictionary<string, Column> Columns { get; private set; }
        #endregion
    }
}
