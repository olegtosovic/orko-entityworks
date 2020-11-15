using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Orko.EntityWorks.Generator
{
	internal class Sql
    {
        #region Constructors
        public Sql(String ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        #endregion

        #region Properties
        public String ConnectionString
        {
            get;
            private set;
        }
        #endregion

        #region Sql
        public DataTable ExecuteSql(String SqlQuery)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand Command = new SqlCommand();
                Command.CommandType = CommandType.Text;
                Command.Connection = sqlConnection;
                Command.CommandText = SqlQuery;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Command);
                sqlDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
        #endregion
    }
}
