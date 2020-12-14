using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Represents entity works generator provider factory.
	/// </summary>
	public abstract class EwgProviderFactory
	{
		#region Properties
		/// <summary>
		/// Registred entity provider factories.
		/// </summary>
		private static ConcurrentDictionary<string, EwgProviderFactory> EwgProviderFactories { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Creates static instance of entity works generator provider factory.
		/// Register all implemented providers.
		/// Providers implemented by user need to be registred manually in calling application.
		/// </summary>
		static EwgProviderFactory()
		{
			// Create instance.
			EwgProviderFactories = new ConcurrentDictionary<string, EwgProviderFactory>();

			// Preregister sql client provider.
			RegisterEWGProvider(SqlClientEWGFactory.Instance.DbProviderTypeName, SqlClientEWGFactory.Instance);

			// Preregister orcale provider.
			RegisterEWGProvider(OracleEwgFactory.Instance.DbProviderTypeName, OracleEwgFactory.Instance);

			// Preregister my sql client provider.
			RegisterEWGProvider(MySqlEwgFactory.Instance.DbProviderTypeName, MySqlEwgFactory.Instance);
		}
		/// <summary>
		/// Creates instance of db provider.
		/// </summary>
		protected EwgProviderFactory()
		{

		}
		#endregion

		#region Properties
		/// <summary>
		/// Db provider type name.
		/// </summary>
		public string DbProviderTypeName { get; protected set; }
		/// <summary>
		/// Entity works generator db sql provider.
		/// </summary>
		public EwgSqlProvider SqlProvider { get; protected set; }
		/// <summary>
		/// Entity works generator type provider.
		/// </summary>
		public EwgTypeConverter TypeProvider { get; protected set; }
		#endregion

		#region Static
		/// <summary>
		/// Registers entity works generator provider.
		/// </summary>
		public static void RegisterEWGProvider(string name, EwgProviderFactory ewgProviderFactory)
		{
			// Add ewg provider if not exists.
			if (EwgProviderFactories.ContainsKey(name))
				return;

			// Add provider.
			EwgProviderFactories.TryAdd(name, ewgProviderFactory);
		}
		/// <summary>
		/// Creates specific entity works generator provider.
		/// </summary>
		public static EwgProviderFactory GetSpecificProvider<TProvider>() where TProvider : EwgProviderFactory, new()
		{
			// Get child instance.
			var instance = (EwgProviderFactory)typeof(TProvider)
				.GetField("Instance")
				.GetValue(null);

			// Create new provider.
			return instance;
		}
		/// <summary>
		/// Creates specific entity works generator provider.
		/// </summary>
		public static EwgProviderFactory GetSpecificProvider(DatabaseGeneratorOptions options)
		{
			// Get specific entity works generator provider.
			if (EwgProviderFactories.TryGetValue(
				options.DbProviderAssembly,
				out EwgProviderFactory ewgProviderFactory))
				return ewgProviderFactory;

			// Throw exception.
			else throw new EntityWorksGeneratorException(string.Format(
				"Current db provider does not have registred matching ew provider. " +
				"Please refer to documentation."));
		}
		#endregion
	}
}
