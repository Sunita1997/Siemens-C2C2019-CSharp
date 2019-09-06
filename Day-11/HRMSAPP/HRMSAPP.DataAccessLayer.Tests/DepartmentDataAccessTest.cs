using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRMSAPP.DataAccessLayer.Implementation;
using System.Collections.Generic;
using HRMSAPP.Entities;

namespace HRMSAPP.DataAccessLayer.Tests
{
    [TestClass]
    public class DepartmentDataAccessTest
    {
        private DepartmentDataAccessComponent dataAccessComponent;

        [TestInitialize]
        public void InitializeAssets()
        {
            dataAccessComponent = new DepartmentDataAccessComponent();
        }
        [TestCleanup]
        public void CleanUpAssets()
        {
            dataAccessComponent = null;
        }
        [TestMethod]
        public void GetDepartmentsPositiveTest()
        {
            var actualDepartments = dataAccessComponent.GetDepartments();
            var expectedDepartments = new List<Department>
            {
                new Department{ DepartmentId=1, DepartmentName="HR"},
                new Department{ DepartmentId=2, DepartmentName="Training"},
                new Department{ DepartmentId=4, DepartmentName="Resources"}
            };
            CollectionAssert.AreEqual(expectedDepartments, actualDepartments);
        }
    }
}
