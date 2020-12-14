using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Represents Microsoft SQL Server data provider.
	/// </summary>
	public class SqlClientEWGFactory : EwgProviderFactory
	{
		#region Instance
		/// <summary>
		/// Represents single instance of specific provider.
		/// </summary>
		public static readonly SqlClientEWGFactory Instance;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates instance of SqlServerEWGFactory object.
		/// </summary>
		static SqlClientEWGFactory()
		{
			// Create static instance of specific provider.
			Instance = new SqlClientEWGFactory();
		}
		/// <summary>
		/// Creates instance of SqlServerEWGFactory object.
		/// </summary>
		private SqlClientEWGFactory() : base()
		{
			// Set provider name.
			this.DbProviderTypeName = "Microsoft.Data.SqlClient";

			// Set child provider sql provider.
			this.SqlProvider = new SqlServerSqlProvider();

			// Set child provider type converter provider.
			this.TypeProvider = new SqlClientTypeProvider();
		}
		#endregion
	}
}
