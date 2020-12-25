using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Orko.EntityWorks.Generator
{
    /// <summary>
    /// Represents database table column with all schema metadata.
    /// </summary>
    public sealed class Column
    {
        #region Members
        private static bool[] _lookup;
        private Dictionary<string, Type> NetTypes { get; set; }
        private Dictionary<string, DbType> DbTypes { get; set; }
        #endregion

        #region Static
        static Column()
        {
            // Valid characters lookup.
            // Optimization taken from stack overflow.
            // https://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string
            _lookup = new bool[65536];
            for (char c = '0'; c <= '9'; c++) _lookup[c] = true;
            for (char c = 'A'; c <= 'Z'; c++) _lookup[c] = true;
            for (char c = 'a'; c <= 'z'; c++) _lookup[c] = true;
            //_lookup['.'] = true;
            _lookup['_'] = true;

        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates instance of column object.
        /// </summary>
        private Column(Table table)
		{
            // Set types from database to member converion.
            NetTypes = table.Database.EwgProviderFactory.TypeProvider.NetTypes;

            // Set types from database to dbtype conversion.
            DbTypes = table.Database.EwgProviderFactory.TypeProvider.DbTypes;
        }
        /// <summary>
        /// Creates instance of column object.
        /// </summary>
        public Column(string columnName, Table table, bool isPartOfPrimaryKey = false, bool isPartOfUniqueKey = false) : this(table)
        {
            // Initialization
            Table = table;
            SqlName = columnName;
            NetName = GetNetValidName(columnName);


            // Retrive columns from data cache.
            var column = Table.ColumnRows
                .Where(
                    column => column.Field<string>("column_name") == columnName 
                ).First();

            // Assign column properties.
            SqlDataTypeName = column["sql_data_type"] != DBNull.Value ? column["sql_data_type"].ToString() : column["sql_data_type_user"].ToString();
            NetDataTypeName = GetSqlDataTypeName(SqlDataTypeName);
            NetDataArgumentTypeName = GetSqlDataArgumentTypeName(SqlDataTypeName);
            DbType = GetDbType(SqlDataTypeName);
            IsPartOfPrimaryKey = (IsPartOfPrimaryKey == true) ? true : isPartOfPrimaryKey;
            IsPartOfUniqueKey = (IsPartOfUniqueKey == true) ? true : isPartOfUniqueKey;
            IsNullable = (bool)column["is_nullable"];
            IsIdentity = (bool)column["is_identity"];
            OrdinalPosition = (int)column["column_id"];
        }
        /// <summary>
        /// Creates instance of column object.
        /// </summary>
        public Column(DataRow column, Table table) : this(table)
        {
            // Initialization
            Table = table;
            SqlName = column["column_name"].ToString();
            NetName = GetNetValidName(SqlName);
            table.Columns.GetOrAdd(SqlName, this);

            // Assign column properties.
            SqlDataTypeName = column["sql_data_type"] != DBNull.Value ? column["sql_data_type"].ToString() : column["sql_data_type_user"].ToString();
            NetDataTypeName = GetSqlDataTypeName(SqlDataTypeName);
            NetDataArgumentTypeName = GetSqlDataArgumentTypeName(SqlDataTypeName);
            DbType = GetDbType(SqlDataTypeName);
            IsNullable = (bool)column["is_nullable"];
            IsIdentity = (bool)column["is_identity"];
            OrdinalPosition = (int)column["column_id"];
        }
        #endregion

        #region Attributes
        public string SqlName { get; private set; }
        public DbType DbType { get; private set; }
        public string SqlDataTypeName { get; private set; }
        public string NetName { get; set; }
        public string NetDataTypeName { get; private set; }
        public string NetDataArgumentTypeName { get; private set; }
        public int OrdinalPosition { get; set; }
        public Table Table { get; private set; }
        #endregion

        #region Key function
        public bool IsPartOfPrimaryKey { get; private set; }
        public bool IsPartOfForeignKey { get; private set; }
        public bool IsPartOfUniqueKey { get; private set; }
        public bool IsIndexed { get; private set; }
        public bool IsNullable { get; private set; }
        public bool IsIdentity { get; private set; }
        public bool IsLanguage { get; set; }
        public bool IsLanguageCode { get; set; }
        #endregion

        #region Helper methods
        public DbType GetDbType(string sqlDataTypeName)
        {
            DbType sqlDbType = DbType.Object;
            if (DbTypes.ContainsKey(sqlDataTypeName))
                sqlDbType = DbTypes[sqlDataTypeName];
            return sqlDbType;
        }
        public string GetSqlDataTypeName(string sqlDataTypeName)
        {
            Type netType = null;
            if (NetTypes.TryGetValue(sqlDataTypeName, out netType) == false)
                return "string";

            if (netType.IsValueType)
            {
                return GetNetSimpleTypeName(netType) + "?";
            }
            else if (netType == typeof(string))
                return "string";
            return netType.Name;
        }
        public string GetNetSimpleTypeName(Type netType)
        {
            if (netType == typeof(int))
                return "int";
            else if (netType == typeof(short))
                return "short";
            else if (netType == typeof(long))
                return "long";
            else if (netType == typeof(string))
                return "string";
            else if (netType == typeof(decimal))
                return "decimal";
            else if (netType == typeof(bool))
                return "bool";
            return netType.Name;
        }
        public string GetSqlDataArgumentTypeName(string sqlDataTypeName)
        {
            Type netType = null;
            if (NetTypes.TryGetValue(sqlDataTypeName, out netType) == false)
                return "string";
            if (netType == typeof(string))
                return "string";
            return GetNetSimpleTypeName(netType);
        }
        public string GetNetValidName(string fieldName)
		{
            // Remove special characters.
            var validNetColumnName = RemoveSpecialCharacters(fieldName);

            // Rename if column name is identical to parent name.
            if (this.Table.NetName == validNetColumnName)
			{
                // Add preffix so that it does not match entity class name.
                // For columns add "c_".
                // For entity properties add "e_".
                validNetColumnName = "c_" + validNetColumnName;
			}

            // Return valid net name.
            return validNetColumnName;
		}
        public static string RemoveSpecialCharacters(string str)
        {
            char[] buffer = new char[str.Length];
            int index = 0;
            foreach (char c in str)
            {
                if (_lookup[c])
                {
                    buffer[index] = c;
                    index++;
                }                
            }
            return new string(buffer, 0, index);
        }
        #endregion
    }
}
