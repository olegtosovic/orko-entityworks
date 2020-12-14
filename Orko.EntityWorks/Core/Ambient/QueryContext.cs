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
		#region Properties
		/// <summary>
		/// Connection string builder.
		/// </summary>
		private DbConnectionStringBuilder DbConnectionStringBuilder { get; set; }
		#endregion

		#region Methods
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor.
		/// </summary>
		public QueryContext()
		{
			// Register provider factory, currently only support for microsoft sql client.
			DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", SqlClientFactory.Instance);

			// Create provider factory.
			DbProviderFactory = DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");

			// Create connection string string builder.
			DbConnectionStringBuilder = DbProviderFactory.CreateConnectionStringBuilder();
		}
		/// <summary>
		/// Creates query context which is used by query object.
		/// </summary>
		public QueryContext(string connectionName) : this()
		{
			// Get entity works context.
			var context = EntityWorksContext.GetEntityWorksContext();

			// Get connection string.
			string connectionString = EntityWorksContext.ConnectionStrings[connectionName];

			// Parse connection string to builder.
			DbConnectionStringBuilder.ConnectionString = connectionString;
			// DbConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
			// DbConnectionStringBuilder.

			// Set connection segments.
			Name = connectionName;
			Database = DbConnectionStringBuilder["Initial Catalog"] as string;
			Username = DbConnectionStringBuilder["User ID"] as string;
			Password = DbConnectionStringBuilder["Password"] as string;
			Hostname = DbConnectionStringBuilder["Data Source"] as string;

			// Set connection string.
			ConnectionString = DbConnectionStringBuilder.ConnectionString;

			// Set language code.
			LanguageCode = context.LanguageCode;
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

		#region Database provider
		/// <summary>
		/// Provider factory.
		/// </summary>
		public DbProviderFactory DbProviderFactory { get; private set; }
		#endregion

		#region Methods
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
		/// <summary>
		/// Creates sql connection object.
		/// </summary>
		public DbConnection CreateConnection(bool enableStatistics = false)
		{
			// Create db connection instance.
			var dbConnection = DbProviderFactory.CreateConnection();

			// Set cb connection.
			dbConnection.ConnectionString = this.ConnectionString;

			// Retrun db connection instance.
			return dbConnection;
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

			// Get default query context. (temp)
			var queryContext = entityWorksContext.DefaultQueryContext;

			// Set language code.
			if (queryContext.LanguageCode == null)
				queryContext.LanguageCode = entityWorksContext.LanguageCode;

			// Return query context.
			return queryContext;
		}
		#endregion

		#region Dispose
		/// <summary>
		/// Removes context from ambient stack.
		/// </summary>
		public void Dispose()
		{

		}
		#endregion
	}
}
