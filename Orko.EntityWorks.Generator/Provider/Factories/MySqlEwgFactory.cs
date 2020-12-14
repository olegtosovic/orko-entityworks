using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Represents MySql data provider.
	/// </summary>
	public class MySqlEwgFactory : EwgProviderFactory
	{
		#region Instance
		/// <summary>
		/// Represents single instance of specific provider.
		/// </summary>
		public static readonly MySqlEwgFactory Instance;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates instance of SqlServerEWGFactory object.
		/// </summary>
		static MySqlEwgFactory()
		{
			// Create static instance of specific provider.
			Instance = new MySqlEwgFactory();
		}
		/// <summary>
		/// Creates instance of SqlServerEWGFactory object.
		/// </summary>
		public MySqlEwgFactory() : base()
		{
			// Set provider name.
			this.DbProviderTypeName = "MySql.Data.SqlClient";

			// Set child provider sql provider.
			this.SqlProvider = new MySqlSqlProvider();

			// Set child provider type provider.
			this.TypeProvider = new OracleTypeProvider();
		}
		#endregion
	}
}
