using System;
using System.Data;
using System.Data.SqlClient;
using static DataAccess_DAL.Utility.DaoUtility;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_DAL
{
    public class EmployeeDataAccess
    {
        public int InsertEmployeeRecord(string empName, string empLocation, decimal empSalary, int empDeptId)
        {
            string connectionString = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            string procedureName = null;
            int result = 0;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        procedureName = GetProcedureName("INSERT_QUERY");
                        command = CreateCommand(connection, procedureName);

                        if (command != null)
                        {
                            SqlParameter pmName = CreateParameter("@name", empName, SqlDbType.VarChar);
                            SqlParameter pmSalary = CreateParameter("@salary", empSalary, SqlDbType.Decimal);
                            SqlParameter pmLocation = CreateParameter("@location", empLocation, SqlDbType.VarChar);
                            SqlParameter pmDeptid = CreateParameter("@deptid", empDeptId, SqlDbType.Int);

                            command.Parameters.Add(pmName);
                            command.Parameters.Add(pmSalary);
                            command.Parameters.Add(pmLocation);
                            command.Parameters.Add(pmDeptid);

                            /*
                            command.Parameters.AddWithValue("@name", "Dhananjay");
                            command.Parameters.AddWithValue("@salary", 23000);
                            command.Parameters.AddWithValue("@location", "Madurai");
                            command.Parameters.AddWithValue("@deptid", 1);
                            */

                            OpenConnection(connection);
                            result = command.ExecuteNonQuery();
                            //if (result > 0)
                            //    Console.WriteLine($"{result} record(s) added successfully");
                            //else
                            //    Console.WriteLine($"no record(s) added");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    CloseConnection(connection);
            }
            return result;
        }
    }
}
