using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Data;
using System.Linq;

namespace Orko.EntityWorks.Generator
{
    public class ForeignKey
    {
        #region Constructors
        public ForeignKey(DataRow foreignKey, Table table)
        {
            // Initialization
            Database = table.Database;
            Table = table;
            ForeignKeyName = foreignKey["foreign_key_name"].ToString();
            ForeignKeyColumnName = GetForeignKeyColumnName(ForeignKeyName);
            Relations = new List<Relation>();

            // Get relations.
            var relations = table.Database.Relations.AsEnumerable()
                .Where(relation => relation.Field<string>("foreign_key_name") == ForeignKeyName)
                .ToList();

            // Load relations
            foreach (DataRow drRelation in relations)
            {
                // Table names
                string fk_table_name = drRelation["foreign_key_table"].ToString();
                string fk_table_schema = drRelation["foreign_key_table_schema"].ToString();
                string fk_table_fullname = drRelation["foreign_key_table_fullname"].ToString();
                string pk_table_name = drRelation["primary_key_table"].ToString();
                string pk_table_schema = drRelation["primary_key_table_schema"].ToString();
                string pk_table_fullname = drRelation["primary_key_table_fullname"].ToString();

                // Column names
                string fk_column_name = drRelation["foreign_key_column"].ToString();
                string pk_column_name = drRelation["primary_key_column"].ToString();

                // Relation
                Relation relation = new Relation
                    (
                        foreignKeyTableName: fk_table_name,
                        foreignKeyTableSchema: fk_table_schema,
                        foreignKeyTableColumnName: fk_column_name,
                        foreignKeyTableFullName: fk_table_fullname,
                        primaryKeyTableName: pk_table_name,
                        primaryKeyTableSchema: pk_table_schema,
                        primaryKeyTableColumnName: pk_column_name,
                        primaryKeyTableFullName: pk_table_fullname
                    );
                Relations.Add(relation);
            }
        }
        #endregion

        #region Properties
        public string ForeignKeyName { get; private set; }
        public string ForeignKeyColumnName { get; private set; }
        public Database Database { get; private set; }
        public Table Table { get; private set; }
        public List<Relation> Relations { get; private set; }
        #endregion

        #region Helper methods
        private string GetForeignKeyColumnName(string ForeignKeyName)
        {
            string foreignKeyName = ForeignKeyName;
            string[] nameParts = foreignKeyName.Split(new char[] { '_' });
            string columnName = nameParts[nameParts.Count() - 1];
            return columnName;
        }
        #endregion
    }
}
