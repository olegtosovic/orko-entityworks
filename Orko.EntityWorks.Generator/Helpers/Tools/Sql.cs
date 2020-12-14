using System;
using System.Data;
using System.Data.Common;

namespace Orko.EntityWorks.Generator
{
	/// <summary>
	/// Provides simple raw sql query execution.
	/// </summary>
	internal class Sql
    {
        #region Constructors
        /// <summary>
        /// Creates instance of SQL object.
        /// </summary>
        /// <param name="connectionString">Sql connection string</param>
        /// <param name="dbProviderFactory">Sql connection string</param>
        public Sql(string connectionString, DbProviderFactory dbProviderFactory)
        {
            // Set db provider.
            DbProviderFactory = dbProviderFactory;

            // Set connection string.
            this.ConnectionString = connectionString;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Connection string.
        /// </summary>
        public string ConnectionString { get; private set; }
        /// <summary>
        /// ADO .NET connectivity provider.
        /// </summary>
        public DbProviderFactory DbProviderFactory { get; private set; }
        #endregion

        #region Sql
        /// <summary>
        /// Exectues query string.
        /// </summary>
        /// <param name="query">raw sql database query</param>
        public DataTable ExecuteSql(string query)
        {
            // Create data container.
            DataTable dataTable = new DataTable();

            // Create connection.
            using (DbConnection dbConnection = DbProviderFactory.CreateConnection())
            {
                // Set connection string.
                dbConnection.ConnectionString = this.ConnectionString;

                // Create db command.
                var dbCommand = DbProviderFactory.CreateCommand();
                dbCommand.CommandType = CommandType.Text;
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = query;

                // Create db apater.
                var dataAdapter = DbProviderFactory.CreateDataAdapter();
                dataAdapter.SelectCommand = dbCommand;

                // Fill data table.
                dataAdapter.Fill(dataTable);
            }

            // Return data table.
            return dataTable;
        }
        #endregion
    }
}
