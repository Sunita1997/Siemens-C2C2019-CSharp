using System;
using Entities;
using System.Data;
using System.Data.SqlClient;
using static DataAccess_DAL.Utility.DaoUtility;
using System.Collections.Generic;

namespace DataAccess_DAL
{
    public class EmployeeDataAccess
    {
        //public int InsertEmployeeRecord(string empName, string empLocation, decimal empSalary, int empDeptId)
        public int InsertEmployeeRecord(Employee employee)
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
                            SqlParameter pmName = CreateParameter("@name", employee.EmployeeName, SqlDbType.VarChar);
                            SqlParameter pmSalary = CreateParameter("@salary", employee.EmployeeSalary, SqlDbType.Decimal);
                            SqlParameter pmLocation = CreateParameter("@location", employee.EmployeeLocation, SqlDbType.VarChar);
                            SqlParameter pmDeptid = CreateParameter("@deptid", employee.DepartmentId, SqlDbType.Int);

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
        public List<Employee> GetAllEmployeeRecords()
        {
            string connectionString = null;
            string procedureName = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Employee> employees = null;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null && connectionString != string.Empty)
                {
                    connection = CreateConnection(connectionString);

                    if (connection != null)
                    {
                        procedureName = GetProcedureName("GETALL_SELECT_QUERY");
                        command = CreateCommand(connection, procedureName);

                        OpenConnection(connection);                        
                        reader = command.ExecuteReader();
                        if (reader != null && reader.HasRows)
                        {
                            employees = new List<Employee>();
                            while (reader.Read())
                            {                              
                                Employee employee = new Employee
                                {
                                    EmployeeName = reader["Name"].ToString(),
                                    EmployeeId = (int)reader["ID"],
                                    EmployeeSalary = (decimal)reader["Salary"],
                                    EmployeeLocation = (string)reader["Location"]
                                };
                                employees.Add(employee);
                            }
                            reader.Close();
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
            return employees;
        }
    }
}
