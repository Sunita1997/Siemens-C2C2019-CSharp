using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, decimal salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name},{Id},{Salary}";
        }
    }
}
