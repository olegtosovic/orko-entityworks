using Orko.EntityWorks.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("Orko.EntityWorks.AspNetCore")]
namespace Orko.EntityWorks
{
	/// <summary>
	/// Provides entityworks runtime configuration options and state.
	/// </summary>
	public sealed class EntityWorksContext
	{
		#region Members
		public Guid m_guid;
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		public EntityWorksContext()
		{
			// Defaults.
			LanguageCode = null;
			DebugMode = false;

			// Context.
			DefaultQueryContext = null;
			GuestQueryContext = null;
			RootQueryContext = null;
			UserQueryContext = null;

			// Initialization flag.
			Initialized = false;

			// Set new guid (temp).
			m_guid = Guid.NewGuid();
		}
		#endregion

		#region Internal properties
		/// <summary>
		/// Connection string collection.
		/// </summary>
		internal static IDictionary<string, string> ConnectionStrings { get; set; }
		/// <summary>
		/// Context mappings collection.
		/// </summary>
		internal static IDictionary<string, string> ContextMappings { get; set; }
		#endregion

		#region Ambient properties
		private ConcurrentDictionary<string, Stack<QueryContext>> m_contextStacks;
		#endregion

		#region Public properties
		/// <summary>
		/// Indicated if debug mode is enabled.
		/// </summary>
		public bool DebugMode { get; internal set; }
		/// <summary>
		/// Indicates if entityworks context is initialized.
		/// </summary>
		public bool Initialized { get; internal set; }
		/// <summary>
		/// Request database language code.
		/// </summary>
		public string LanguageCode { get; set; }
		/// <summary>
		/// Default query context that needs no scope.
		/// </summary>
		public QueryContext DefaultQueryContext { get; internal set; }
		/// <summary>
		/// Guest user context.
		/// </summary>
		public QueryContext GuestQueryContext { get; internal set; }
		/// <summary>
		/// Administrative query context.
		/// </summary>
		public QueryContext RootQueryContext { get; internal set; }
		/// <summary>
		/// Authorized user context.
		/// </summary>
		public QueryContext UserQueryContext { get; internal set; }
		#endregion

		#region Startup initialization
		/// <summary>
		/// Set debug mode.
		/// </summary>
		public EntityWorksContext SetDebugMode(bool value)
		{
			// Set debug mode.
			this.DebugMode = value;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets connection string source to be used by query context.
		/// </summary>
		public static void SetConnectionStringSource(IDictionary<string, string> nameValueDictionary)
		{
			// Validate connection string source.
			if (ConnectionStrings != null)
				throw new EntityWorksException("Connection string source already set.");
			if (nameValueDictionary == null)
				throw new EntityWorksException("Connection string source cannot be null. Make sure to pass valid instance of dictionary containing connection strings from app.config or appsettings.json.");
			if (nameValueDictionary.Count == 0)
				throw new EntityWorksException("Connection string source cannot have 0 connection strings. Make sure that app.config or appsettings.json have at least one connection string.");

			// Set connection string source.
			EntityWorksContext.ConnectionStrings = nameValueDictionary;
		}
		/// <summary>
		/// Sets context mappings source to be used by query context.
		/// </summary>
		public static void SetContextMappingsSource(IDictionary<string, string> nameValueDictionary)
		{
			// Validate connection string source.
			if (ContextMappings != null)
				throw new EntityWorksException("Context mappings source already set.");
			if (nameValueDictionary == null)
				throw new EntityWorksException("Context mappings source cannot be null. Make sure to pass valid instance of dictionary containing context mappings from app.config or appsettings.json.");
			if (nameValueDictionary.Count == 0)
				throw new EntityWorksException("Context mappings source cannot have 0 connection strings. Make sure that app.config or appsettings.json have at least one context mapping string.");

			// Set connection string source.
			EntityWorksContext.ContextMappings = nameValueDictionary;
		}
		/// <summary>
		/// Sets language code.
		/// </summary>
		public EntityWorksContext SetLanguageCode(string languageCode)
		{
			// Validate.
			if (string.IsNullOrEmpty(languageCode))
				throw new EntityWorksException("Language code canot be null. Make sure to provide default localization culture code.");

			// Set language code.
			this.LanguageCode = languageCode;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Registers guest query context to be used by entity query.
		/// </summary>
		public EntityWorksContext RegisterGuestContext()
		{
			// Get guest context mapping.
			var guestContextName = ContextMappings["GuestContext"];

			// Set query context.
			this.GuestQueryContext = new QueryContext(guestContextName);

			// Set as default.
			this.DefaultQueryContext = this.GuestQueryContext;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Registers root query context to be used by entity query.
		/// </summary>
		public EntityWorksContext RegisterRootContext()
		{
			// Get root context mapping.
			var rootContextName = ContextMappings["RootContext"];

			// Set query context.
			this.RootQueryContext = new QueryContext(rootContextName);

			// Return instance.
			return this;
		}
		/// <summary>
		/// Registers user query context to be used by entity query.
		/// </summary>
		public EntityWorksContext RegisterUserContext()
		{
			// Get user context mapping.
			var userContextName = ContextMappings["UserContext"];

			// Set query context.
			this.UserQueryContext = new QueryContext(userContextName);

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets default query context.
		/// </summary>
		public EntityWorksContext SetDefaultContext(QueryContextType queryContextType)
		{
			// Return instance.
			return this;
		}
		#endregion

		#region Context transformation methods
		/// <summary>
		/// Changes query context parameters.
		/// </summary>
		internal EntityWorksContext TransformUserContext(string database)
		{
			// Change database name.
			UserQueryContext.SetDatabase(database);

			// Return instance.
			return this;
		}
		/// <summary>
		/// Changes query context parameters.
		/// </summary>
		internal EntityWorksContext TransformUserContext(string database, string username)
		{
			// Change database name.
			UserQueryContext.SetDatabase(database);

			// Change username.
			UserQueryContext.SetUsername(username);

			// Return instance.
			return this;
		}
		/// <summary>
		/// Changes query context parameters.
		/// </summary>
		internal EntityWorksContext TransformUserContext(string database, string username, string password)
		{
			// Change database name.
			UserQueryContext.SetDatabase(database);

			// Change username.
			UserQueryContext.SetUsername(username);

			// Change password.
			UserQueryContext.SetPassword(password);

			// Return instance.
			return this;
		}
		#endregion

		#region Instance validation
		/// <summary>
		/// Validates if all parameters are set.
		/// </summary>
		public static void ValidateInstance(EntityWorksContext instance)
		{
			// Validate if debug mode on.
			if (instance.DebugMode)
			{
				// Validate language code.
				if (string.IsNullOrWhiteSpace(instance.LanguageCode))
					throw new EntityWorksException("Language code canot be null. Make sure to provide default localization culture code.");

				// Validate if default query context is set.
				else if (instance.DefaultQueryContext == null)
					throw new EntityWorksException("Default query context not initialized. Make sure to provide valid connection string and register default query context.");

				// Validate if user query context is set.
				else if (instance.UserQueryContext == null)
					throw new EntityWorksException("User query context not initialized. Make sure to provide valid connection string and register user query context.");

				// Validate if root query context is set.
				else if (instance.UserQueryContext == null)
					throw new EntityWorksException("Root query context not initialized. Make sure to provide valid connection string and register root query context.");
			}
		}
		#endregion

		#region Get Context
		/// <summary>
		/// Get current instance of entityworks context.
		/// </summary>
		public static EntityWorksContext GetEntityWorksContext()
		{
			// Get entityworks context instance from provider.
			return EntityWorksContextProvider.GetEntityWorksContext();
		}
		#endregion
	}
}
