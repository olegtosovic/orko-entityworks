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
        /// <summary>
        /// Create foreign key instance.
        /// </summary>
        /// <param name="foreignKey">Raw db data for foreign key creation</param>
        /// <param name="table">Parent table</param>
        public ForeignKey(DataRow foreignKey, Table table)
        {
            // Initialization
            Database = table.Database;
            Table = table;
            SqlName = foreignKey["foreign_key_name"].ToString();
            NetName = TransformForeignKeyNameByConvention(SqlName);

            // Create instances.
            Columns = new ConcurrentDictionary<string, Column>();
            Relations = new List<Relation>();

            // Get relations.
            var relations = table.Database.Relations.AsEnumerable()
                .Where(relation => relation.Field<string>("foreign_key_name") == SqlName &&
                       relation.Field<string>("foreign_key_table_fullname") == table.SqlFullName)
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

                // Create new relation
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

                // Add relation.
                Relations.Add(relation);

                // Get column from table columns.
                var column = table.Columns.GetOrAdd(fk_column_name,
                    column => { return new Column(fk_column_name, table); }
                    );

                // Add to column list.
                this.Columns.TryAdd(fk_column_name, column);
            }
        }
        #endregion

        #region Properties
        public string SqlName { get; private set; }
        public string NetName { get; private set; }
        public Database Database { get; private set; }
        public Table Table { get; private set; }
        public List<Relation> Relations { get; private set; }
        public ConcurrentDictionary<string, Column> Columns { get; private set; }
        #endregion

        #region Helper methods
        /// <summary>
        /// Transforms foreign key name by foreign key name convention.
        /// </summary>
        private string TransformForeignKeyNameByConvention(string foreignKeyName)
        {
            // Parent table.
            var table = this.Table;

            // Generator options.
            var options = this.Table.Database.Options;

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

            // If first column full name convention no ID.
            else if (options.ForeignKeyNamingConvention == ForeignKeyNamingConvention.FK_FC_FN_NID)
			{
                // Set foreign key name as first column full name.
                var firstColumnPartOfKey = table.PrimaryKey.Columns.FirstOrDefault();
                foreignKeyName = firstColumnPartOfKey.Value.SqlName.Replace("ID", string.Empty);
            }

            // Transform by member policy.
            foreignKeyName = TransformForeignKeyNameByNetMemberPolicy(foreignKeyName);

            // Return foreign key name.
            return foreignKeyName;
        }
        /// <summary>
        /// Transforms foreign key name by foreign key name member policy.
        /// </summary>
        private string TransformForeignKeyNameByNetMemberPolicy(string foreignKeyName)
		{
            // If foreign key name already transformed by name convention is identical to entity class name than add preffix "e_".
            if (foreignKeyName == this.Table.NetName)
                foreignKeyName = "e_" + foreignKeyName;

            // Else, if foreign key name already transformed by name convention is identical to any column name than also add prefix. "e_".
            else if (this.Table.Columns.GetValueOrDefault(foreignKeyName) != null)
                foreignKeyName = "e_" + foreignKeyName;

            // Return foreign key name.
            return foreignKeyName;
		}
        #endregion
    }
}
