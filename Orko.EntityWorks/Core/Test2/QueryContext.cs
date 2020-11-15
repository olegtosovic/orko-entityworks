using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
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
		private SqlConnectionStringBuilder m_builder;
		#endregion

		#region Constructors
		/// <summary>
		/// Creates query context which is used by query object.
		/// </summary>
		public QueryContext(string connectionName)
		{
			// Get entity works context.
			//var context = EntityWorksContext.GetEntityWorksContext();

			// Get connection string.
			string connectionString = EntityWorksContext.ConnectionStrings[connectionName];

			// Parse connection string to builder.
			m_builder = new SqlConnectionStringBuilder(connectionString);

			// Set connection segments.
			Name = connectionName;
			Database = m_builder.InitialCatalog;
			Username = m_builder.UserID;
			Password = m_builder.Password;
			Hostname = m_builder.DataSource;

			// Set connection string.
			ConnectionString = m_builder.ConnectionString;

			// Set language code.
			LanguageCode = null;
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

		#region Public methods
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
			m_builder.DataSource = host;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets database name.
		/// </summary>
		public QueryContext SetDatabase(string database)
		{
			// Set hostname.
			m_builder.InitialCatalog = database;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Sets database sql user name.
		/// </summary>
		public QueryContext SetUsername(string username)
		{
			// Set hostname.
			m_builder.UserID = username;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Set database sql user password.
		/// </summary>
		public QueryContext SetPassword(string password)
		{
			// Set hostname.
			m_builder.Password = password;

			// Return instance.
			return this;
		}
		/// <summary>
		/// Creates sql connection object.
		/// </summary>
		public SqlConnection CreateConnection(bool enableStatistics = false)
		{
			// Create sql connection instance.
			var sqlConnection = new SqlConnection(m_builder.ConnectionString);

			// Enable statistics.
			sqlConnection.StatisticsEnabled = enableStatistics;

			// Retrun sql connection instance.
			return sqlConnection;
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
