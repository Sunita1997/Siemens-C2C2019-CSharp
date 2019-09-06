using System.Collections.Generic;
using HRMSAPP.Entities;

namespace HRMSAPP.DataAccessLayer.Contract
{
    public interface IDepartmentDataAccessComponent
    {
        List<Department> GetDepartments();
    }
}