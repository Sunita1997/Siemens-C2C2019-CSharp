using System.Collections.Generic;
using HRMSAPP.Entities;

namespace HRMSAPP.BusinessLayer.Contract
{
    public interface IEmployeeBusinessComponent
    {
        List<Employee> FetchEmployeeByDepartment(int departmentId);
        int RemoveEmployee(int employeeId);
    }
}