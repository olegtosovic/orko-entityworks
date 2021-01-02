using Microsoft.Data.SqlClient;
using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Orko.EntityWorks.AspNetCore")]
namespace Orko.EntityWorks
{
	/// <summary>
	/// Represents query context in terms of server, database and credidentials.
	/// Use this if you want to run queries against different server and database.
	/// </summary>
	public class QueryContext : IDisposable
	{
		#region Members
		/// <summary>
		/// Inidicates if object is already disposed.
		/// </summary>
		private bool m_isDisposed;
		/// <summary>
		/// Indicates if context is ambient context.
		/// </summary>
		private bool m_isAmbient;
		#endregion

		#region Properties
		/// <summary>
		/// Connection string builder.
		/// </summary>
		private DbConnectionStringBuilder DbConnectionStringBuilder { get; set; }
		#endregion

		#region Methods
		/// <summary>
		/// Creates connection object.
		/// </summary>
		internal DbConnection CreateConnection()
		{
			// Create db connection instance.
			var dbConnection = DbProviderFactory.CreateConnection();

			// Set cb connection.
			dbConnection.ConnectionString = this.ConnectionString;

			// Retrun db connection instance.
			return dbConnection;
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Creates query context instance.
		/// </summary>
		internal QueryContext(string connectionContextName)
		{
			// Get entity works context.
			var entityWorksContext = EntityWorksContext.GetEntityWorksContext();

			// Get connection context.
			this.ConnectionContext = EntityWorksContext.ConnectionContexts[connectionContextName];

			// Set db provider factory.
			this.DbProviderFactory = this.ConnectionContext.GetSpecificDbProvider();

			// Set db string builder.
			this.DbConnectionStringBuilder = DbProviderFactory.CreateConnectionStringBuilder();

			// Parse connection string to builder.
			this.DbConnectionStringBuilder.ConnectionString = ConnectionContext.ConnectionString;

			// Set connection segments.
			Name = connectionContextName;
			Database = DbConnectionStringBuilder["Initial Catalog"] as string;
			Username = DbConnectionStringBuilder["User ID"] as string;
			Password = DbConnectionStringBuilder["Password"] as string;
			Hostname = DbConnectionStringBuilder["Data Source"] as string;

			// Set connection string.
			ConnectionString = DbConnectionStringBuilder.ConnectionString;

			// Set default language code.
			LanguageCode = entityWorksContext.LanguageCode;
		}
		/// <summary>
		/// Creates query context instance.
		/// </summary>
		protected QueryContext(string connectionContextName, bool isAmbientContext) : this(connectionContextName)
		{
			// Set ambient indicator.
			m_isAmbient = isAmbientContext;

			// Set ambiance.
			SetAmbiance();
		}
		#endregion

		#region Finalizers
		// Finalizer.
		~QueryContext()
		{
			// Finalizer calls Dispose(false)
			Dispose(false);
		}
		#endregion

		#region Properties
		public int? CurrentPort { get; private set; }
		public int? DefaultPort { get; private set; }
		public string Name { get; private set; }
		public string Hostname { get; private set; }
		public string Database { get; private set; }
		public string Username { get; private set; }
		public string Password { get; private set; }
		public string ConnectionString { get; private set; }
		public string LanguageCode { get; private set; }
		#endregion

		#region Connection properties
		/// <summary>
		/// Provider factory.
		/// </summary>
		public DbProviderFactory DbProviderFactory { get; private set; }
		/// <summary>
		/// Connection context.
		/// </summary>
		public ConnectionContext ConnectionContext { get; private set; }
		#endregion

		#region Connection methods
		/// <summary>
		/// Sets language code for database language tables.
		/// </summary>
		public QueryContext SetLangaugeCode(string languageCode)
		{
			// Set language code.
			this.LanguageCode = languageCode;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets server address.
		/// </summary>
		public QueryContext SetHostname(string host)
		{
			// Set hostname.
			//DbConnectionStringBuilder.DataSource = host;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets database name.
		/// </summary>
		public QueryContext SetDatabase(string database)
		{
			// Set hostname.
			//m_builder.InitialCatalog = database;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets database sql user name.
		/// </summary>
		public QueryContext SetUsername(string username)
		{
			// Set hostname.
			//m_builder.UserID = username;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Set database sql user password.
		/// </summary>
		public QueryContext SetPassword(string password)
		{
			// Set hostname.
			//m_builder.Password = password;

			// Return instance.
			return this;
		}
		#endregion

		#region Ambient methods
		/// <summary>
		/// Sets context as ambient context.
		/// </summary>
		private void SetAmbiance()
		{
			// Get entity works context.
			var entityWorksContext = EntityWorksContext.GetEntityWorksContext();

			// Enlist.
			entityWorksContext.EnlistAmbientContext(this);
		}
		#endregion

		#region Get ambient context
		/// <summary>
		/// Gets ambient query context.
		/// </summary>
		internal static QueryContext GetAmbientQueryContext()
		{
			// Get entity works context.
			var entityWorksContext = EntityWorksContext.GetEntityWorksContext();

			// Validate instance if debug mode.
			EntityWorksContext.ValidateInstance(entityWorksContext);

			// Get ambient query context.
			var queryContext = entityWorksContext.PeekAmbientContext();

			// Set language code.
			if (queryContext.LanguageCode == null)
				queryContext.LanguageCode = entityWorksContext.LanguageCode;

			// Return query context.
			return queryContext;
		}
		#endregion

		#region Dispose implementation
		/// <summary>
		/// Removes context from ambient stack.
		/// </summary>
		public void Dispose()
		{
			// Dispose only if it is ambient context.
			if (m_isAmbient)
			{
				// Dispose.
				Dispose(true);

				// Suppres finalize.
				GC.SuppressFinalize(this);
			}
		}
		/// <summary>
		/// Protected implementation of Dispose pattern.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			// If disposed return.
			if (m_isDisposed)
				return;			

			// If disposing release managed objects.
			if (disposing)
			{
				// Get entity works context.
				var entityWorksContext = EntityWorksContext.GetEntityWorksContext();

				// Delist ambient context.
				entityWorksContext.DelistAmbientContext(this);
			}

			// Set disposed indicator true.
			m_isDisposed = true;
		}
		#endregion
	}
}
