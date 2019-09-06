using HRMSAPP.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static HRMSAPP.DataAccessLayer.Utility.DaoUtility;
using HRMSAPP.DataAccessLayer.Contract;

namespace HRMSAPP.DataAccessLayer.Implementation
{
    public class DepartmentDataAccessComponent : IDepartmentDataAccessComponent
    {
        public List<Department> GetDepartments()
        {
            string connectionString = null;
            string procedureName = null;
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Department> departments = null;
            try
            {
                connectionString = GetConnectionString();
                if (connectionString != null)
                {
                    connection = CreateConnection(connectionString);
                    if (connection != null)
                    {
                        procedureName = GetProcedureName("GET_DEPARTMENTS_QUERY");
                        if (procedureName != null && procedureName != string.Empty)
                        {
                            command = CreateCommand(connection, procedureName);
                            if (command != null)
                            {
                                OpenConnection(connection);
                                if (connection.State == ConnectionState.Open)
                                {
                                    reader = command.ExecuteReader();
                                    if (reader.HasRows)
                                    {
                                        departments = new List<Department>();
                                        while (reader.Read())
                                        {
                                            departments.Add(new Department
                                            {
                                                DepartmentId = (int)reader["departmentid"],
                                                DepartmentName = (string)reader["departmentname"]
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
            return departments;
        }
    }
}
