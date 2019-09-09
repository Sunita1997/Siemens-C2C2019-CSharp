using HRMSAPP.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static HRMSAPP.DataAccessLayer.Utility.DaoUtility;
using HRMSAPP.DataAccessLayer.Contract;

namespace HRMSAPP.DataAccessLayer.Implementation
{
    public class EmployeeDataAccessComponent : IEmployeeDataAccessComponent
    {
        public List<Employee> GetEmployeeFromADepartment(int departmentId)
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
                if (connectionString != null)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        procedureName = GetProcedureName("GET_DEPARTMENT_EMPLOYEES_QUERY");
                        if (procedureName != null && procedureName != string.Empty)
                        {
                            command = CreateCommand(connection, procedureName);

                            if (command != null)
                            {
                                SqlParameter parameterDeptId = CreateParameter("@deptid", departmentId, SqlDbType.Int);
                                command.Parameters.Add(parameterDeptId);

                                OpenConnection(connection);

                                if (connection.State == ConnectionState.Open)
                                {
                                    reader = command.ExecuteReader();
                                    if (reader.HasRows)
                                    {
                                        employees = new List<Employee>();
                                        while (reader.Read())
                                        {
                                            employees.Add(new Employee
                                            {
                                                DepartmentId = (int)reader["departmentid"],
                                                EmployeeName = (string)reader["employeename"],
                                                EmployeeId = (int)reader["employeeid"],
                                                EmployeeLocation = (string)reader["employeelocation"],
                                                EmployeeSalary = (decimal)reader["employeesalary"]
                                            });
                                        }
                                        reader.Close();
                                    }
                                }
                                else
                                {
                                    throw new Exception("couldn't open connection");
                                }
                            }
                            else
                            {
                                throw new NullReferenceException("could not create commnd");
                            }
                        }
                        else
                        {
                            throw new NullReferenceException($"could not get  stored procedure name from configuraion file. either no name saved or no key present with name =>{procedureName} ");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("could not create connection");
                    }
                }
                else
                {
                    throw new NullReferenceException("could not get connection string from configuraion file");
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

        public int DeleteEmployeeRecord(int employeeId)
        {
            string connectionString = null;
            string procedureName = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            int deleteStatus = 0;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        procedureName = GetProcedureName("DELETE_EMPLOYEE_QUERY");
                        if (procedureName != null && procedureName != string.Empty)
                        {
                            command = CreateCommand(connection, procedureName);

                            if (command != null)
                            {
                                SqlParameter parameterEmployeeId = CreateParameter("@id", employeeId, SqlDbType.Int);
                                SqlParameter parameterResult = CreateParameter("@res", null, SqlDbType.Int, ParameterDirection.Output);
                                command.Parameters.Add(parameterEmployeeId);
                                command.Parameters.Add(parameterResult);

                                OpenConnection(connection);
                                command.ExecuteNonQuery();
                                deleteStatus = (int)parameterResult.Value;
                            }
                            else
                            {
                                throw new NullReferenceException("could not create commnd");
                            }
                        }
                        else
                        {
                            throw new NullReferenceException($"could not get  stored procedure name from configuraion file. either no name saved or no key present with name =>{procedureName} ");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("could not create connection");
                    }
                }
                else
                {
                    throw new NullReferenceException("could not get connection string from configuraion file");
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
            return deleteStatus;
        }

        public int ModifyEmployeeRecord(Employee employee)
        {
            string connectionString = null;
            string procedureName = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            int updateStatus = 0;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        procedureName = GetProcedureName("UPDATE_EMPLOYEE_QUERY");
                        if (procedureName != null && procedureName != string.Empty)
                        {
                            command = CreateCommand(connection, procedureName);

                            if (command != null)
                            {
                                SqlParameter parameterEmployeeId = CreateParameter("@id", employee.EmployeeId, SqlDbType.Int);
                                SqlParameter parameterEmployeeName = CreateParameter("@name", employee.EmployeeName, SqlDbType.VarChar);
                                SqlParameter parameterEmployeeSalary = CreateParameter("@salary", employee.EmployeeSalary, SqlDbType.Decimal);
                                SqlParameter parameterEmployeeLocation = CreateParameter("@location", employee.EmployeeLocation, SqlDbType.VarChar);
                                SqlParameter parameterEmployeeDeptid = CreateParameter("@deptid", employee.DepartmentId, SqlDbType.Int);

                                SqlParameter parameterResult = CreateParameter("@result", null, SqlDbType.Int, ParameterDirection.Output);

                                command.Parameters.Add(parameterEmployeeId);
                                command.Parameters.Add(parameterEmployeeDeptid);
                                command.Parameters.Add(parameterEmployeeLocation);
                                command.Parameters.Add(parameterEmployeeName);
                                command.Parameters.Add(parameterEmployeeSalary);
                                command.Parameters.Add(parameterResult);

                                OpenConnection(connection);
                                command.ExecuteNonQuery();
                                updateStatus = (int)parameterResult.Value;
                            }
                            else
                            {
                                throw new NullReferenceException("could not create commnd");
                            }
                        }
                        else
                        {
                            throw new NullReferenceException($"could not get  stored procedure name from configuraion file. either no name saved or no key present with name =>{procedureName} ");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("could not create connection");
                    }
                }
                else
                {
                    throw new NullReferenceException("could not get connection string from configuraion file");
                }
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
            return updateStatus;
        }

        public int InsertEmployeeRecord(Employee employee)
        {
            string connectionString = null;
            string procedureName = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            int insertStatus = 0;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        procedureName = GetProcedureName("ADD_EMPLOYEE_QUERY");
                        if (procedureName != null && procedureName != string.Empty)
                        {
                            command = CreateCommand(connection, procedureName);

                            if (command != null)
                            {

                                SqlParameter parameterEmployeeName = CreateParameter("@name", employee.EmployeeName, SqlDbType.VarChar);
                                SqlParameter parameterEmployeeSalary = CreateParameter("@salary", employee.EmployeeSalary, SqlDbType.Decimal);
                                SqlParameter parameterEmployeeLocation = CreateParameter("@location", employee.EmployeeLocation, SqlDbType.VarChar);
                                SqlParameter parameterEmployeeDeptid = CreateParameter("@deptid", employee.DepartmentId, SqlDbType.Int);

                                command.Parameters.Add(parameterEmployeeDeptid);
                                command.Parameters.Add(parameterEmployeeLocation);
                                command.Parameters.Add(parameterEmployeeName);
                                command.Parameters.Add(parameterEmployeeSalary);

                                OpenConnection(connection);
                                insertStatus =
                                    command.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new NullReferenceException("could not create commnd");
                            }
                        }
                        else
                        {
                            throw new NullReferenceException($"could not get  stored procedure name from configuraion file. either no name saved or no key present with name =>{procedureName} ");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("could not create connection");
                    }
                }
                else
                {
                    throw new NullReferenceException("could not get connection string from configuraion file");
                }
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
            return insertStatus;
        }
    }
}
