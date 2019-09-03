using System;
using System.Collections.Generic; //using CalculationLibrary;
using System.Linq; //using extensionlibrary;

namespace ExtensionMethodImplementation
{
    class Program
    {
        static IEnumerable<T> Filter<T>(List<T> input, Predicate<T> logic)
        {
            List<T> output = new List<T>();
            foreach (T item in input)
            {
                if (logic(item))
                    output.Add(item);
            }

            return output;
        }
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 3, 4, 2, 6, 8, 5, 0, 9, 7 };
            //Language Integrated Query (Method Query)
            numbers
                .Where(num => num % 2 == 0)
                .OrderBy(num => num)
                .ToList<int>()
                .ForEach(num => Console.WriteLine(num));

            //Func<int, bool> evenLogic = (num) => num % 2 == 0;
            //Func<int, int> sortLogic = (num) => num;            
            //Action<int> printLogic = item => Console.WriteLine(item);

            //Predicate<int> oddLogic = num => num % 2 != 0;

            //IEnumerable<int> result = numbers.Where(evenLogic);
            //List<int> evenNumbers = result.ToList<int>();
            //evenNumbers.ForEach(printLogic);
            //foreach (int item in numbers)
            //{
            //   Console.WriteLine(item);
            //}
            /*
            Predicate<int> evenLogic = num => num % 2 == 0;
            //evenLogic(12);
            List<int> result = Filter<int>(numbers, evenLogic);

            Action<int> printLogic = item => Console.WriteLine(item);
            //printLogic(12);
            result.ForEach(printLogic);
            //foreach (int item in result)
            //{
            //    printLogic(item);
            //}
            */
        }
    }
}
