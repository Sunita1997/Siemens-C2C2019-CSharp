using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess_DAL.Utility
{
    internal static class DaoUtility
    {
        public static string GetConnectionString()
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
        public static SqlConnection CreateConnection(string connectionString)
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
        public static SqlCommand CreateCommand(SqlConnection connection, string query, CommandType commandType = CommandType.StoredProcedure)
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
        public static void OpenConnection(SqlConnection connection)
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
        public static void CloseConnection(SqlConnection connection)
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
        public static string GetProcedureName(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static SqlParameter CreateParameter(string parameterName, object parameterValue, SqlDbType parameterDbType, ParameterDirection parameterDirection = ParameterDirection.Input)
        {
            SqlParameter parameter = null;
            try
            {
                parameter = new SqlParameter();
                parameter.ParameterName = parameterName;
                parameter.Value = parameterValue;
                parameter.SqlDbType = parameterDbType;
                parameter.Direction = parameterDirection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return parameter;
        }
    }
}
