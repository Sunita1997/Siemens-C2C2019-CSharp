using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee{ Name="sunil", Id=2, Salary=30000 },
                new Employee{ Name="anil", Id=3, Salary=10000 },
                new Employee{ Name="vinod", Id=1, Salary=20000 }
            };
            //1.
            Func<Employee, bool> filterLogic = e => e.Name.Contains('s');
            Func<Employee, decimal> sortLogic = e => e.Salary;
            Action<Employee> printLogic = e => Console.WriteLine(e);

            //method syntax
            employees
                .Where(filterLogic)
                .OrderBy(sortLogic)
                .ToList<Employee>()
                .ForEach(printLogic);

            //query syntax
            var query = from e in employees
                        where e.Name.Contains('s')
                        orderby e.Salary ascending
                        select e;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            //implicitly typed local variable
            //var query = 10;
            //query = 12.34;
            //var arr = new[] { 1, 2, 3, 4 };

            //dynamic d = 10;
            //Console.WriteLine(d);
            //d = 12.34;
            //Console.WriteLine(d);
        }
    }
}
