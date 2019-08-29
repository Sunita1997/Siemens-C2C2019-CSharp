using System;

namespace CSharpNewFetaures_v4
{
    class Student
    {
        public string Name { get; set; }
        public double Marks { get; set; }
        public dynamic Subject { set; get; }
    }
    class Program
    {
        static void DynamicDemo()
        {
            dynamic student = new Student { Name = "anil", Marks = 45 };

            student.Subject = "Dot Net";
            Console.WriteLine($"{student.Name}, {student.Marks}, {student.Subject}");

            dynamic dynamicVariable = 100;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = "Hello World!!";
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = true;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = DateTime.Now;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
        }
        static void Main()
        {
            DynamicDemo();
        }
    }
}
