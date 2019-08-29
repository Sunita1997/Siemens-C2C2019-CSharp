using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpNewFetaures_v6
{
    class Student
    {
        private string name;
        public string Name { get => name; set => name = value ?? throw new ArgumentException($"{nameof(Name)} property can't be null", $" {nameof(value)}"); }
        //public static string SchoolName { get; set; } = "Siemens";

        //the value assigned directly to a readonly backing field, which can be set to by ctor only again
        public static string SchoolName { get; } = "Siemens";
        static Student()
        {
            if (!string.IsNullOrEmpty(SchoolName))
            {
                SchoolName = "Siemens";
            }
        }
    }
    class Program
    {
        static void TestMethod(string name)
        {
            WriteLine($"{nameof(name)}");
        }
        static void Main()
        {
            //Student.SchoolName = ""; <--not possible
            WriteLine(Student.SchoolName);
            Student student = new Student();
            student.Name = null;
            TestMethod("joydip");
        }
    }
}
