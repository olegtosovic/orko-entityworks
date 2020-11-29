using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
    public class UniqueKey
    {
        #region Constructors
        public UniqueKey(IEnumerable<DataRow> columns, Table table)
        {
            // Initialization
            Table = table;
            Columns = new Dictionary<string, Column>();

            // Load unique key columns.
            Name = columns.First()["unique_key_name"].ToString();
            foreach (DataRow uniqueKeyColumn in columns)
            {
                string columnName = uniqueKeyColumn["column_name"].ToString();
                Column column = table.CreateColumn(columnName, isPartOfUniqueKey: true);
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
