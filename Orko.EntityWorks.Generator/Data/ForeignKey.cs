using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Data;
using System.Linq;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Represents foreign key constraint.
    /// </summary>
    public class ForeignKey
    {
        #region Constructors
        public ForeignKey(DataRow foreignKey, Table table)
        {
            // Initialization
            Database = table.Database;
            Table = table;
            ForeignKeyName = foreignKey["foreign_key_name"].ToString();
            ForeignKeyColumnName = GetForeignKeyColumnName(ForeignKeyName, table);
            Relations = new List<Relation>();

            // Get relations.
            var relations = table.Database.Relations.AsEnumerable()
                .Where(relation => relation.Field<string>("foreign_key_name") == ForeignKeyName &&
                       relation.Field<string>("foreign_key_table_fullname") == table.FullName)
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
        /// <summary>
        /// Gets foreign key name.
        /// </summary>
        private string GetForeignKeyColumnName(string foreignKeyName, Table table)
        {
            // Get options.
            var options = table.Database.Options;

            // If converter is set by user convert and return.
            if (options.ForeignKeyNameNamingConverter != null)
            {
                // Get primary key columns.
                var primaryKeyColumns = table.PrimaryKey.Columns.Select(x => x.Value.SqlName);

                // Apply user defined conversion.
                foreignKeyName = options.ForeignKeyNameNamingConverter(foreignKeyName, primaryKeyColumns);

                // Return user defined foreign key name.
                return foreignKeyName;
            }

            // If full name convention we take full foreign key name to be entity property name.
            if (options.ForeignKeyNamingConvention == ForeignKeyNamingConvention.FK_FN)
            {
                return foreignKeyName;
            }

            // If last segment convention we take only last segment of foreign key name to be entity property name.
            else if (options.ForeignKeyNamingConvention == ForeignKeyNamingConvention.FK_LS)
            {
                string[] nameParts = foreignKeyName.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                string columnName = nameParts[nameParts.Count() - 1];
                foreignKeyName = columnName;
            }

            // If first column full name convention.
            else if (options.ForeignKeyNamingConvention == ForeignKeyNamingConvention.FK_FC_FN)
			{
                // Set foreign key name as first column full name.
                var firstColumnPartOfKey = table.PrimaryKey.Columns.FirstOrDefault();
                foreignKeyName = firstColumnPartOfKey.Value.SqlName;
			}

            // Return foreign key name.
            return foreignKeyName;
        }
        #endregion
    }
}
