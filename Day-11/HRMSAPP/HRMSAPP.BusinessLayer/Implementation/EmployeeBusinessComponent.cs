using HRMSAPP.BusinessLayer.Contract;
using HRMSAPP.DataAccessLayer.Implementation;
using HRMSAPP.Entities;
using System;
using System.Collections.Generic;

namespace HRMSAPP.BusinessLayer.Implementation
{
    public class EmployeeBusinessComponent : IEmployeeBusinessComponent
    {
        private EmployeeDataAccessComponent employeeDataAccessComponent;

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
    }
}
