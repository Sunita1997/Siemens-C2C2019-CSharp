using System;
using System.Data; //ConnectionState and CommandType enums
using System.Data.SqlClient; //SqlConnection, SqlCommand, (SqlDataReader)
using System.Configuration; //ConfigurationManager

namespace DataAccess_NonSelectQuery
{
    class Program
    {
        static string GetConnectionString()
        {
            string connectionString = null;
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["siemensDbConStr"].ConnectionString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connectionString;
        }
        static SqlConnection CreateConnection(string connectionString)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connection;
        }
        static SqlCommand CreateCommand(SqlConnection connection, string query, CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand command = null;
            try
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = commandType;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return command;
        }
        static void OpenConnection(SqlConnection connection)
        {           
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static void Main()
        {
            try
            {

            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
