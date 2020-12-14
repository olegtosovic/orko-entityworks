using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Represents Oracle data provider.
	/// </summary>
	public class OracleEwgFactory : EwgProviderFactory
	{
		#region Instance
		/// <summary>
		/// Represents single instance of specific provider.
		/// </summary>
		public static readonly OracleEwgFactory Instance;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates instance of SqlServerEWGFactory object.
		/// </summary>
		static OracleEwgFactory()
		{
			// Create static instance of specific provider.
			Instance = new OracleEwgFactory();
		}
		/// <summary>
		/// Creates instance of SqlServerEWGFactory object.
		/// </summary>
		public OracleEwgFactory() : base()
		{
			// Set provider name.
			this.DbProviderTypeName = "Oracle.Data.SqlClient";

			// Set child provider sql provider.
			this.SqlProvider = new OracleSqlProvider();

			// Set child provider type converter provider.
			this.TypeProvider = new OracleTypeProvider();
		}
		#endregion
	}
}
