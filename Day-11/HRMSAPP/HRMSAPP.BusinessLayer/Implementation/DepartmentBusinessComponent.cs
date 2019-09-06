using HRMSAPP.BusinessLayer.Contract;
using HRMSAPP.DataAccessLayer.Implementation;
using HRMSAPP.Entities;
using System;
using System.Collections.Generic;

namespace HRMSAPP.BusinessLayer.Implementation
{
    public class DepartmentBusinessComponent : IDepartmentBusinessComponent
    {
        private DepartmentDataAccessComponent departmentDataAccessComponent;

        public List<Department> FetchDepartments()
        {
            try
            {
                departmentDataAccessComponent = new DepartmentDataAccessComponent();
                return departmentDataAccessComponent.GetDepartments();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }               
    }
}
