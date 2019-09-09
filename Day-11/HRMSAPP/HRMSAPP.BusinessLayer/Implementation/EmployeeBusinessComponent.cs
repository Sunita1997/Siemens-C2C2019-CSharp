using HRMSAPP.BusinessLayer.Contract;
using HRMSAPP.DataAccessLayer.Contract;
using HRMSAPP.DataAccessLayer.Implementation;
using HRMSAPP.Entities;
using System;
using System.Collections.Generic;

namespace HRMSAPP.BusinessLayer.Implementation
{
    public class EmployeeBusinessComponent : IEmployeeBusinessComponent
    {
        private IEmployeeDataAccessComponent employeeDataAccessComponent;

        public int AddNewEmployee(Employee employee)
        {
            
            try
            {
                employeeDataAccessComponent = new EmployeeDataAccessComponent();
                int result = employeeDataAccessComponent.InsertEmployeeRecord(employee);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> FetchEmployeeByDepartment(int departmentId)
        {
            try
            {
                employeeDataAccessComponent = new EmployeeDataAccessComponent();
                return employeeDataAccessComponent.GetEmployeeFromADepartment(departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RemoveEmployee(int employeeId)
        {
            try
            {
                employeeDataAccessComponent =
                    new EmployeeDataAccessComponent();
                return employeeDataAccessComponent.DeleteEmployeeRecord(employeeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            try
            {
                employeeDataAccessComponent =
                    new EmployeeDataAccessComponent();
               int result = employeeDataAccessComponent
                    .ModifyEmployeeRecord(employee);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
