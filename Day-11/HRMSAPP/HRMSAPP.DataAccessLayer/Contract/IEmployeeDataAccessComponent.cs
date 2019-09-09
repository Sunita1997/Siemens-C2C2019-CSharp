using System.Collections.Generic;
using HRMSAPP.Entities;

namespace HRMSAPP.DataAccessLayer.Contract
{
    public interface IEmployeeDataAccessComponent
    {
        int DeleteEmployeeRecord(int employeeId);
        List<Employee> GetEmployeeFromADepartment(int departmentId);
        int ModifyEmployeeRecord(Employee employee);
        int InsertEmployeeRecord(Employee employee);
    }
}