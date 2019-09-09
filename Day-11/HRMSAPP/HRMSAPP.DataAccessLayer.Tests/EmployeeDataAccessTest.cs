using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRMSAPP.DataAccessLayer.Implementation;
using HRMSAPP.Entities;
using System.Collections.Generic;

namespace HRMSAPP.DataAccessLayer.Tests
{
    [TestClass]
    public class EmployeeDataAccessTest
    {
        private EmployeeDataAccessComponent dataAccessComponent;

        [TestInitialize]
        public void InitializeAssets()
        {
            dataAccessComponent = new EmployeeDataAccessComponent();
        }

        [TestCleanup]
        public void CleanUpAssets()
        {
            dataAccessComponent = null;
        }

        [TestMethod]
        public void GetEmployeeFromADepartmentPositiveTest()
        {
            var actualCount = dataAccessComponent.GetEmployeeFromADepartment(1).Count;
            var expectedCount = 5;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void DeleteEmployeeRecordPositiveTest()
        {
            var actualCount = dataAccessComponent.DeleteEmployeeRecord(3102);
            var expectedCount = 1;
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void ModifyEmployeeRecordPositiveTest()
        {
            var actualCount = dataAccessComponent.ModifyEmployeeRecord(
                new Employee
                {
                    EmployeeId = 105,
                    EmployeeName = "Phaniraj",
                    EmployeeSalary = 25500,
                    EmployeeLocation = "Chennai",
                    DepartmentId = 2
                });
            var expectedCount = 1;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void InsertEmployeeRecordPositiveTest()
        {
            var actualCount = dataAccessComponent.InsertEmployeeRecord(
                new Employee
                {
                    EmployeeName = "Dhananjay",
                    EmployeeSalary = 23700,
                    EmployeeLocation = "Mangalore",
                    DepartmentId = 1
                });
            var expectedCount = 1;
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
