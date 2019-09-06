using System;

namespace HRMSAPP.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public string EmployeeLocation { get; set; }
        public int DepartmentId { get; set; }

        public Department DepartmentInfo { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, decimal salary, string location, int? departmentId = null, Department department = null)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeeSalary = salary;
            EmployeeLocation = location;
            if (departmentId.HasValue)
                DepartmentId = departmentId.Value;
            if (department != null)
                DepartmentInfo = department;
        }

        public override string ToString()
        {
            return $"{EmployeeName},{EmployeeId},{EmployeeSalary},{DepartmentId}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new NullReferenceException($"null reference was passed to {nameof(this.Equals)} method");

            if (!(obj is Employee))
                throw new ArgumentException($"{obj.GetType().Name} to {nameof(this.Equals)} method instaed of {this.GetType().Name} type");

            Employee other = obj as Employee;

            if (!this.EmployeeId.Equals(this.EmployeeId))
                return false;

            if (!this.EmployeeName.Equals(this.EmployeeName))
                return false;

            if (!this.EmployeeSalary.Equals(this.EmployeeSalary))
                return false;

            if (!this.EmployeeLocation.Equals(this.EmployeeLocation))
                return false;

            if (!this.DepartmentId.Equals(this.DepartmentId))
                return false;

            if (!this.DepartmentInfo.Equals(this.DepartmentInfo))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            const int prime = 23;
            return this.EmployeeId.GetHashCode() * prime;
        }
    }
}
