using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Collections.Concurrent;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Represents table primary key.
    /// </summary>
    public class PrimaryKey
    {
        #region Constructors
        /// <summary>
        /// Creates primary key instance.
        /// </summary>
        /// <param name="table">Parent table</param>
        public PrimaryKey(Table table)
        {
            // Initialization
            Table = table;

            // Create instances.
            Columns = new ConcurrentDictionary<string, Column>();

            // Retrieve primary key columns from data cache.
            var primaryKeyColumns = table.Database.PrimaryKeys
                .AsEnumerable()
                .Where (
                    pKeyColumn => pKeyColumn.Field<string>("table_name") == table.SqlName &&
                    pKeyColumn.Field<string>("table_schema_name") == table.Schema)
                .ToList();

            // Get primary key name.
            SqlName = primaryKeyColumns.First()["primarykey_name"].ToString();

            // For each raw column in primary key columns create column and save it to table columns and primary key columns.
            foreach (var primaryKeyColumn in primaryKeyColumns)
            {
                // Get column name.
                var columnName = primaryKeyColumn["column_name"].ToString();

                // Create column and save it to table columns.
                var column = table.CreateColumn(columnName, isPartOfprimaryKey: true);

                // Also save column to this primary key columns.
                Columns.TryAdd(columnName, column);
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Primary key sql name.
        /// </summary>
        public string SqlName { get; private set; }
        /// <summary>
        /// Primary key table.
        /// </summary>
        public Table Table { get; private set; }
        /// <summary>
        /// Primary key columns.
        /// </summary>
        public ConcurrentDictionary<string, Column> Columns { get; private set; }
        #endregion
    }
}
