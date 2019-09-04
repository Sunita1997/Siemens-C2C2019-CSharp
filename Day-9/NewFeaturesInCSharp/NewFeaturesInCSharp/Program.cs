using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesInCSharp
{
    delegate void SimpleDel(object obj);
    class Student
    {
        //auto-implemented/automatic properties
        public string Name { get; set; }
        public static string City { get; private set; } = "Bangalore";

        private string schoolName;
        public Student()
        {

        }
        public Student(string schoolName)
        {
            this.schoolName = schoolName;
        }
        public string SchoolName
        {
            get { return schoolName; }
            //private setter
            //private set { schoolName = value; }
            set { schoolName = value; }
        }
    }
    class Ano
    {
        private readonly string _FirstName;
        private readonly string _LastName;
        public Ano()
        {
            _FirstName = FirstName;
            _LastName = LastName;
        }

        public string FirstName => _FirstName;

        public string LastName => _LastName;
    }
    class Program
    {
        static void Print(object obj)
        {
            Console.WriteLine(obj);
        }
        static void Main()
        {
            Sample sample = new Sample();
            sample.Foo();
            //Nullable types
            Nullable<int> x = null;
            int? y = null;
            x = 10;
            if (x.HasValue)
                Console.WriteLine(x.Value);

            //SimpleDel simpleDel = new SimpleDel(Print);
            //Method group conversions (delegates)
            SimpleDel simpleDel = Print;
            simpleDel(12);

            //anonymous method
            simpleDel = delegate (object obj)
              {
                  Console.WriteLine($"Value: {obj}");
              };
            simpleDel("siemens");

            //a --> implicitly typed local variable
            //type inference: technique where compiler understands (interprets) data type of implicitly typed local variable by looking at the assigned value
            var a = 10;
            var arr = new[] { 1, 2, 3, 4 };
            var list = new List<int>();
            foreach (var item in list)
            {

            }
            //Student student = new Student("siemens");
            //student.Name = "anil";

            //object initializer
            Student student = new Student { Name = "anil", SchoolName = "siemens" };
            //collection initlaizer
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            List<Student> students = new List<Student>
            {
                new Student{Name="anil", SchoolName="siemens"}
            };

            //anonymous type
            var person = new { FirstName = "anil", LastName = "gupta" };
            Console.WriteLine(person.GetType().Name);
            //person.FirstName = "";

            //query expression
            IEnumerable<string> query = from s in students
                                        where s.Name.Contains('a')
                                        orderby s.Name
                                        select s.Name;

            //method expression
            IEnumerable<Student> filteredCollection =
                students.Where(s => s.Name.Contains('a'));

            IOrderedEnumerable<Student> sortedCollection = filteredCollection.OrderBy(s => s.Name);

            IEnumerable<string> finalCollection =
                sortedCollection.Select(s => s.Name);

            //Func<int, bool> del = (num) => num % 2 == 0;

            bool IsEven(int num) => num % 2 == 0;
            Console.WriteLine(IsEven(5));

            void Test(out int m) => m = 12;
            Test(out int z);
            Console.WriteLine($"value of {nameof(z)} is {z}");
        }
    }
}
