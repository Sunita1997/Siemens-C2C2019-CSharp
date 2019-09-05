using System;
using DataAccess_DAL;
using Entities;
//using System.Data; //ConnectionState, CommandType, SqlDbType enums
//using System.Data.SqlClient; //SqlConnection, SqlCommand, (SqlDataReader)
//using System.Configuration; //ConfigurationManager

namespace DataAccess_NonSelectQuery
{
    class Program
    {
        static void AddRecord(EmployeeDataAccess dataAccess)
        {
            Employee employee = new Employee
            {
                EmployeeLocation = "Bangalore",
                EmployeeName = "suresh",
                EmployeeSalary = 42000,
                DepartmentId = 1
            };
            //int result = dataAccess.InsertEmployeeRecord("ajay", "Mangalore", 34000, 2);
            int result = dataAccess.InsertEmployeeRecord(employee);
            if (result > 0)
                Console.WriteLine($"{result} record(s) added successfully");
            else
                Console.WriteLine($"no record(s) added");
        }
        static void Main()
        {
            EmployeeDataAccess dataAccess = null;
            try
            {
                dataAccess = new EmployeeDataAccess();

                //AddRecord(dataAccess);
                ViewAll(dataAccess);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void ViewAll(EmployeeDataAccess dataAccess)
        {
            var allRecords = dataAccess.GetAllEmployeeRecords();
            allRecords.ForEach(e => Console.WriteLine(e));
        }
    }
}
