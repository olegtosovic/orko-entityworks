using Orko.EntityWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orko.WinConsole
{
	/// <summary>
	/// Configures entity works.
	/// </summary>
	public class EntityWorksConfiguration
	{
		#region Constructors
		/// <summary>
		/// Creates object of entity works setup.
		/// </summary>
		public EntityWorksConfiguration()
		{

		}
		#endregion

		#region Public methods
		/// <summary>
		/// Initializes entity works runtime.
		/// </summary>
		public void InitializeEntityWorks()
		{
			// Create connection context.
			var connectionContext = new ConnectionContext(
				"Data Source=DESKTOP-JLE7CPB;Initial Catalog=AdventureWorks;Integrated Security=True",
				"Microsoft.Data.SqlClient",
				"Microsoft.Data.SqlClient.SqlClientFactory");

			// Create connection context dictionary.
			var ccDictionary = new Dictionary<string, ConnectionContext>();
			ccDictionary.Add("AdventureWorks", connectionContext);

			// Create connection mappings dictionary.
			var mcDictionary = new Dictionary<string, string>();
			mcDictionary.Add("GuestContext", "AdventureWorks");
			mcDictionary.Add("UserContext", "AdventureWorks");
			mcDictionary.Add("RootContext", "AdventureWorks");

			// Set entity works connection context source.
			EntityWorksContext.SetConnectionStringSource(ccDictionary);

			// Set entity works connection mappings source.
			EntityWorksContext.SetContextMappingsSource(mcDictionary);

			// Get entity works context instance.
			var entityWorksContext = EntityWorksContext.GetEntityWorksContext();

			// Initialize entity works context.
			entityWorksContext
				.RegisterGuestContext()
				.RegisterRootContext()
				.RegisterUserContext()
				.SetLanguageCode("HR")
				.SetDebugMode(true);
		}
		#endregion
	}
}
