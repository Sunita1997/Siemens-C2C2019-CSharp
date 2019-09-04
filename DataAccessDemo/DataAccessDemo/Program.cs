using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessDemo
{
    class Program
    {
        //this method helps you access the connection string from App.config file
        static string GetConnectionString()
        {
            //ConfigurationManager--> helps to access settings from configuration file (present in System.Configuration namespace from system.configuration.dll)
            string connectionString = null;
            try
            {
                /*
                var connectionSettings = ConfigurationManager.ConnectionStrings;
                var singleConnectionSetting = connectionSettings["siemensDbConStr"];
                connectionString = singleConnectionSetting.ConnectionString;
                */
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
                //connection = new SqlConnection(connectionString);
                connection = new SqlConnection { ConnectionString = connectionString };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connection;
        }
        static SqlCommand CreateCommand(SqlConnection connection, string query)
        {
            SqlCommand command = null;
            try
            {
                //command = new SqlCommand(query, connection);
                command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = query
                };
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
                ConnectionState state = connection.State;
                if (state == ConnectionState.Closed)
                {
                    connection.Open();
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
        }
        static void CloseConnection(SqlConnection connection)
        {
            try
            {
                ConnectionState state = connection.State;
                if (state == ConnectionState.Open)
                {
                    connection.Close();
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
        }
        static void Main()
        {
            string connectionString = null;
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
                        //command = CreateCommand(connection, "select count(employeeid) from employees");
                        command = CreateCommand(connection, "select employeename as Name, employeeid as ID, employeesalary as Salary, employeelocation as Location from employees");
                        OpenConnection(connection);
                        //var value = command.ExecuteScalar();
                        reader = command.ExecuteReader();
                        //Console.WriteLine(value);
                        if (reader != null && reader.HasRows)
                        {
                            employees = new List<Employee>();
                            while (reader.Read())
                            {
                                //string data = null;
                                //for (int i = 0; i < reader.FieldCount; i++)
                                //{
                                //    data += reader[i] + " ";
                                //}
                                //data += reader["ID"].ToString()+" ";
                                //data += reader["Name"].ToString();
                                //data += reader["Salary"].ToString();
                                //data += reader["Location"].ToString();
                                //Console.WriteLine(data);
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
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (connection != null)
                    CloseConnection(connection);

                if (employees != null && employees.Count > 0)
                {
                    employees
                        .Where(e => e.EmployeeSalary > 20000)
                        .OrderBy(e => e.EmployeeName)
                        .GroupBy(e => e.EmployeeLocation)
                        .Select(g =>
                        new
                        {
                            GroupKey = g.Key,
                            Employees = g.OrderBy(e => e.EmployeeLocation).ToList<Employee>()
                        })
                        .ToList()
                        .ForEach(ano =>
                        {
                            Console.WriteLine(ano.GroupKey);
                            Console.WriteLine("-------------------");
                            ano.Employees.ForEach(e => Console.WriteLine(e));
                        });
                }
            }

        }
    }
}
