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
    public sealed class Column
    {
        #region Members
        private static bool[] _lookup;
        #endregion

        #region Constructors
        static Column()
        {
            // Initialization
            NetTypes = new Dictionary<string, Type>(35);
            SqlDbTypes = new Dictionary<string, SqlDbType>(35);

            // Load net types.
            NetTypes.Add("bigint", typeof(Int64));
            NetTypes.Add("binary", typeof(byte[]));
            NetTypes.Add("bit", typeof(bool));
            NetTypes.Add("char", typeof(string));
            NetTypes.Add("date", typeof(DateTime));
            NetTypes.Add("datetime", typeof(DateTime));
            NetTypes.Add("datetime2", typeof(DateTime));
            NetTypes.Add("datetimeoffset", typeof(DateTimeOffset));
            NetTypes.Add("decimal", typeof(decimal));
            NetTypes.Add("float", typeof(double));
            NetTypes.Add("geography", typeof(object));
            NetTypes.Add("geometry", typeof(object));
            NetTypes.Add("hierarchyid", typeof(object));
            NetTypes.Add("image", typeof(byte[]));
            NetTypes.Add("int", typeof(Int32));
            NetTypes.Add("money", typeof(decimal));
            NetTypes.Add("nchar", typeof(string));
            NetTypes.Add("ntext", typeof(string));
            NetTypes.Add("numeric", typeof(decimal));
            NetTypes.Add("nvarchar", typeof(string));
            NetTypes.Add("real", typeof(float));
            NetTypes.Add("rowversion", typeof(byte[]));
            NetTypes.Add("smalldatetime", typeof(DateTime));
            NetTypes.Add("smallint", typeof(Int16));
            NetTypes.Add("smallmoney", typeof(decimal));
            NetTypes.Add("sql_variant", typeof(object));
            NetTypes.Add("sysname", typeof(string));
            NetTypes.Add("text", typeof(string));
            NetTypes.Add("time", typeof(TimeSpan));
            NetTypes.Add("timestamp", typeof(byte[]));
            NetTypes.Add("tinyint", typeof(byte));
            NetTypes.Add("uniqueidentifier", typeof(Guid));
            NetTypes.Add("varbinary", typeof(byte[]));
            NetTypes.Add("varchar", typeof(string));
            NetTypes.Add("xml", typeof(XElement));

            // Load sql db types.
            SqlDbTypes.Add("bigint", SqlDbType.BigInt);
            SqlDbTypes.Add("binary", SqlDbType.Binary);
            SqlDbTypes.Add("bit", SqlDbType.Bit);
            SqlDbTypes.Add("char", SqlDbType.Char);
            SqlDbTypes.Add("date", SqlDbType.Date);
            SqlDbTypes.Add("datetime", SqlDbType.DateTime);
            SqlDbTypes.Add("datetime2", SqlDbType.DateTime2);
            SqlDbTypes.Add("datetimeoffset", SqlDbType.DateTimeOffset);
            SqlDbTypes.Add("decimal", SqlDbType.Decimal);
            SqlDbTypes.Add("float", SqlDbType.Float);
            SqlDbTypes.Add("geography", SqlDbType.Variant);
            SqlDbTypes.Add("geometry", SqlDbType.Variant);
            SqlDbTypes.Add("hierarchyid", SqlDbType.Variant);
            SqlDbTypes.Add("image", SqlDbType.Image);
            SqlDbTypes.Add("int", SqlDbType.Int);
            SqlDbTypes.Add("money", SqlDbType.Money);
            SqlDbTypes.Add("nchar", SqlDbType.NChar);
            SqlDbTypes.Add("ntext", SqlDbType.NText);
            SqlDbTypes.Add("numeric", SqlDbType.Decimal);
            SqlDbTypes.Add("nvarchar", SqlDbType.NVarChar);
            SqlDbTypes.Add("real", SqlDbType.Real);
            SqlDbTypes.Add("rowversion", SqlDbType.Variant);
            SqlDbTypes.Add("smalldatetime", SqlDbType.SmallDateTime);
            SqlDbTypes.Add("smallint", SqlDbType.SmallInt);
            SqlDbTypes.Add("smallmoney", SqlDbType.SmallMoney);
            SqlDbTypes.Add("sql_variant", SqlDbType.Variant);
            SqlDbTypes.Add("sysname", SqlDbType.NVarChar);
            SqlDbTypes.Add("text", SqlDbType.Text);
            SqlDbTypes.Add("time", SqlDbType.Time);
            SqlDbTypes.Add("timestamp", SqlDbType.Timestamp);
            SqlDbTypes.Add("tinyint", SqlDbType.TinyInt);
            SqlDbTypes.Add("uniqueidentifier", SqlDbType.UniqueIdentifier);
            SqlDbTypes.Add("varbinary", SqlDbType.VarBinary);
            SqlDbTypes.Add("varchar", SqlDbType.VarChar);
            SqlDbTypes.Add("xml", SqlDbType.Xml);

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
        public Column(string columnName, Table table, bool isPartOfPrimaryKey = false, bool isPartOfUniqueKey = false)
        {
            // Initialization
            SqlName = columnName;
            NetName = GetNetValidName(columnName);
            Table = table;

            // Retrive columns from data cache.
            var tableColumn = Table.ColumnRows
                .Where(
                    column => column.Field<string>("column_name") == columnName 
                ).First();

            // Assign column properties.
            SqlDataTypeName = tableColumn["sql_data_type"].ToString();
            NetDataTypeName = GetSqlDataTypeName(SqlDataTypeName);
            NetDataArgumentTypeName = GetSqlDataArgumentTypeName(SqlDataTypeName);
            SqlDbType = GetSqlDbType(SqlDataTypeName);
            IsPartOfPrimaryKey = (IsPartOfPrimaryKey == true) ? true : isPartOfPrimaryKey;
            IsPartOfUniqueKey = (IsPartOfUniqueKey == true) ? true : isPartOfUniqueKey;
            IsNullable = (bool)tableColumn["is_nullable"];
            IsIdentity = (bool)tableColumn["is_identity"];
            OrdinalPosition = (int)tableColumn["column_id"];
        }
        public Column(DataRow column, Table table)
        {
            // Initialization
            SqlName = column["column_name"].ToString();
            NetName = GetNetValidName(SqlName);
            Table = table;
            table.Columns.GetOrAdd(SqlName, this);

            // Assign column properties.
            SqlDataTypeName = column["sql_data_type"].ToString();
            NetDataTypeName = GetSqlDataTypeName(SqlDataTypeName);
            NetDataArgumentTypeName = GetSqlDataArgumentTypeName(SqlDataTypeName);
            SqlDbType = GetSqlDbType(SqlDataTypeName);
            IsNullable = (bool)column["is_nullable"];
            IsIdentity = (bool)column["is_identity"];
            OrdinalPosition = (int)column["column_id"];
        }
        #endregion

        #region Attributes
        public string SqlName { get; private set; }
        public SqlDbType SqlDbType { get; private set; }
        public string SqlDataTypeName { get; private set; }
        public string NetName { get; set; }
        public string NetDataTypeName { get; private set; }
        public string NetDataArgumentTypeName { get; private set; }
        public int OrdinalPosition { get; set; }
        public Table Table { get; private set; }
        #endregion

        #region Cache type conversion
        private static Dictionary<string, Type> NetTypes { get; set; }
        private static Dictionary<string, SqlDbType> SqlDbTypes { get; set; }
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
        public SqlDbType GetSqlDbType(string sqlDataTypeName)
        {
            SqlDbType sqlDbType = SqlDbType.Variant;
            if (SqlDbTypes.ContainsKey(SqlDataTypeName))
                sqlDbType = SqlDbTypes[SqlDataTypeName];
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
