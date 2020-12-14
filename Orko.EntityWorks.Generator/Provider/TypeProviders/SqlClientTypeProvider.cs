using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Provides type conversions between Microsoft SQL Server database types and net types.
	/// </summary>
	public class SqlClientTypeProvider : EwgTypeConverter
	{
		#region Constructors
		/// <summary>
		/// Creates instance of sql client type converter.
		/// </summary>
		public SqlClientTypeProvider()
		{
            // Create net type instance.
            NetTypes = new Dictionary<string, Type>(35);

            // Create db types instance.
            DbTypes = new Dictionary<string, DbType>(35);

            // Set net member types.
            NetTypes.Add("bigint", typeof(long));
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
            NetTypes.Add("int", typeof(int));
            NetTypes.Add("money", typeof(decimal));
            NetTypes.Add("nchar", typeof(string));
            NetTypes.Add("ntext", typeof(string));
            NetTypes.Add("numeric", typeof(decimal));
            NetTypes.Add("nvarchar", typeof(string));
            NetTypes.Add("real", typeof(float));
            NetTypes.Add("rowversion", typeof(byte[]));
            NetTypes.Add("smalldatetime", typeof(DateTime));
            NetTypes.Add("smallint", typeof(short));
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

            // Set sql database types.
            DbTypes.Add("bigint", DbType.Int64);
            DbTypes.Add("binary", DbType.Binary);
            DbTypes.Add("bit", DbType.Boolean);
            DbTypes.Add("char", DbType.AnsiStringFixedLength);
            DbTypes.Add("date", DbType.Date);
            DbTypes.Add("datetime", DbType.DateTime);
            DbTypes.Add("datetime2", DbType.DateTime2);
            DbTypes.Add("datetimeoffset", DbType.DateTimeOffset);
            DbTypes.Add("decimal", DbType.Decimal);
            DbTypes.Add("float", DbType.Double);
            DbTypes.Add("geography", DbType.Object);
            DbTypes.Add("geometry", DbType.Object);
            DbTypes.Add("hierarchyid", DbType.Object);
            DbTypes.Add("image", DbType.Binary);
            DbTypes.Add("int", DbType.Int32);
            DbTypes.Add("money", DbType.Decimal);
            DbTypes.Add("nchar", DbType.StringFixedLength);
            DbTypes.Add("ntext", DbType.String);
            DbTypes.Add("numeric", DbType.Decimal);
            DbTypes.Add("nvarchar", DbType.String);
            DbTypes.Add("real", DbType.Single);
            DbTypes.Add("rowversion", DbType.Binary);
            DbTypes.Add("smalldatetime", DbType.DateTime);
            DbTypes.Add("smallint", DbType.Int16);
            DbTypes.Add("smallmoney", DbType.Decimal);
            DbTypes.Add("sql_variant", DbType.Object);
            DbTypes.Add("sysname", DbType.String);
            DbTypes.Add("text", DbType.String);
            DbTypes.Add("time", DbType.Time);
            DbTypes.Add("timestamp", DbType.Binary);
            DbTypes.Add("tinyint", DbType.Byte);
            DbTypes.Add("uniqueidentifier", DbType.Guid);
            DbTypes.Add("varbinary", DbType.Binary);
            DbTypes.Add("varchar", DbType.String);
            DbTypes.Add("xml", DbType.Xml);
        }
		#endregion
	}
}
