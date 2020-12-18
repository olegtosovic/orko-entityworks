using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks
{
	/// <summary>
	/// Provides basic connection context information and specific db provider creation.
	/// </summary>
	public sealed class ConnectionContext
	{
		#region Constructors
		/// <summary>
		/// Creates instance of connection context object.
		/// </summary>
		public ConnectionContext(string connectionString, string providerAssembly, string providerFactory)
		{
			// Set connection string.
			this.ConnectionString = connectionString;

			// Set provider assembly.
			this.DbProviderAssembly = providerAssembly;

			// Set provider factory.
			this.DbProviderFactory = providerFactory;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Database connection string.
		/// </summary>
		public string ConnectionString { get; private set; }
		/// <summary>
		/// Db Provider assembly name.
		/// </summary>
		public string DbProviderAssembly { get; private set; }
		/// <summary>
		/// Db provider factory name.
		/// </summary>
		public string DbProviderFactory { get; private set; }
		#endregion

		#region Methods
		/// <summary>
		/// Gets specific database provider.
		/// </summary>
		public DbProviderFactory GetSpecificDbProvider()
		{
			// Get provider assembly.
			var providerAssembly = Assembly.Load(DbProviderAssembly);

			// Get provider assembly.
			var providerType = providerAssembly.GetType(DbProviderFactory);

			// Get provider instance.
			var providerInstance = providerType.GetField("Instance").GetValue(null);

			// Return db provider factory.
			return (DbProviderFactory)providerInstance;
		}
		#endregion
	}
}
