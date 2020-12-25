using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Provides raw sql queries for getting database metadata from microsfot sql server database.
	/// </summary>
	public class SqlServerSqlProvider : EwgSqlProvider
	{
		#region Constructors
		/// <summary>
		/// Creates instance of entity works generator sql server sql provider object.
		/// </summary>
		public SqlServerSqlProvider() : base()
		{
			// Set provider name.
			//this.pr
		}
		#endregion

		#region Overrides
		/// <summary>
		/// Sets table names query.
		/// </summary>
		protected override void SetTableNamesQuery()
		{
			this.TableNamesQuery =
				"SELECT SCHEMA_NAME(t.schema_id) table_schema_name, " +
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
		}
		/// <summary>
		/// Sets query for column names.
		/// </summary>
		protected override void SetColumnsQuery()
		{
			this.ColumnsQuery =
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

			this.ColumnsQuery =
				"SELECT " +
				"sys.columns.name column_name," +
				"sys.columns.column_id column_id," +
				"sys.columns.precision column_precision, " +
				"sys.columns.scale column_scale," +
				"sys.columns.max_length column_max_length," +
				"SCHEMA_NAME(t.schema_id) table_schema_name, " +
				"OBJECT_NAME(sys.columns.object_id) table_name, " +
				"COLUMNPROPERTY(sys.columns.object_id, sys.columns.name, 'charmaxlen') max_characters, " +
				"TYPE_NAME(sys.columns.user_type_id) sql_data_type_user, " +
				"TYPE_NAME(sys.columns.system_type_id) sql_data_type, " +
				"sys.columns.is_identity, " +
				"sys.columns.is_nullable " +
				"FROM sys.columns " +
				"inner join sys.tables t on t.object_id = sys.columns.object_id " +
				"LEFT JOIN sys.extended_properties ep ON ep.major_id = t.object_id " +
				"AND ep.name = 'microsoft_database_tools_support' " +
				"AND ep.class_desc = 'OBJECT_OR_COLUMN' " +
				"INNER JOIN sys.types AS st " +
				"ON sys.columns.system_type_id = st.system_type_id " +
				"AND sys.columns.user_type_id = st.user_type_id " +
				"WHERE t.is_ms_shipped = 0 " +
				"AND OBJECTPROPERTY(t.object_id, 'TableHasPrimaryKey') = 1 " +
				"AND ep.major_id IS NULL " +
				"ORDER BY table_schema_name ASC, table_name ASC, column_id ASC;";
		}
		/// <summary>
		/// Sets query for foreign key realtions.
		/// </summary>
		protected override void SetForeignKeyRelationsQuery()
		{
			this.ForeignKeyRelationsQuery =
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
		}
		/// <summary>
		/// Sets query for foreign keys.
		/// </summary>
		protected override void SetForeignKeysQuery()
		{
			this.ForeignKeysQuery =
				"SELECT DISTINCT OBJECT_NAME(fkeys.object_id) AS foreign_key_name, " +
				"SCHEMA_NAME(tbls.schema_id) table_schema_name,  " +
				"OBJECT_NAME(fkeys.parent_object_id) table_name " +
				"FROM sys.foreign_keys fkeys " +
				"INNER JOIN sys.foreign_key_columns fkeyc ON fkeys.object_id = fkeyc.constraint_object_id " +
				"INNER JOIN sys.tables tbls ON tbls.object_id = fkeys.parent_object_id " +
				"ORDER BY 1 ASC";
		}
		/// <summary>
		/// Sets query for primary keys.
		/// </summary>
		protected override void SetPrimaryKeysQuery()
		{
			this.PrimaryKeysQuery =
				"SELECT c.name column_name, i.name primarykey_name, " +
				"SCHEMA_NAME(t.schema_id) table_schema_name, " +
				"OBJECT_NAME(i.object_id) table_name " +
				"FROM sys.indexes AS i " +
				"INNER JOIN sys.index_columns AS ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id " +
				"INNER JOIN sys.columns AS c ON ic.object_id = c.object_id AND c.column_id = ic.column_id " +
				"INNER JOIN sys.tables t ON ic.object_id = t.object_id  " +
				"WHERE i.is_primary_key = 1; ";
		}
		/// <summary>
		/// Sets query for unique keys.
		/// </summary>
		protected override void SetUniqueKeysQuery()
		{
			this.UniqueKeysQuery =
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
		}
		#endregion
	}
}
