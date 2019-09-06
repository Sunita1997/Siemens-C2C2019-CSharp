using System.Collections.Generic;
using HRMSAPP.Entities;

namespace HRMSAPP.BusinessLayer.Contract
{
    public interface IDepartmentBusinessComponent
    {
        List<Department> FetchDepartments();
    }
}