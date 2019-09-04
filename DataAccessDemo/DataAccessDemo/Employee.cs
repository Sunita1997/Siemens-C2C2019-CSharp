using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public string EmployeeLocation { get; set; }
        public Department DepartmentInfo { get; set; }
        public override string ToString()
        {
            return $"{EmployeeName},{EmployeeId},{EmployeeSalary}";
        }
    }
}
