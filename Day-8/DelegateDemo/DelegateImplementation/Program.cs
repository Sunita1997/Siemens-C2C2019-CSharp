using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateImplementation
{
    delegate bool LogicInvoker<in T>(T number);
    class Logic
    {
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }
        public bool IsGreater(int num)
        {
            return num > 5 ? true : false;
        }
    }
    class Program
    {
        //public class LogicHolder
        //{
        //    public bool Test(int num)
        //    {
        //        return num > 2 && num < 8 ? true : false;
        //    }
        //}

        static List<T> Filter<T>(List<T> input, LogicInvoker<T> invoker)
        {
            List<T> output = new List<T>();
            foreach (T item in input)
            {
                if (invoker(item))
                    output.Add(item);
            }
            return output;
        }

        static void Main()
        {
            List<int> dataSource = new List<int> { 1, 3, 2, 4, 6, 7, 5, 9, 0, 8 };
            //LogicInvoker<int> logic = new LogicInvoker<int>(new Logic().IsGreater);

            //anonymous method
            //LogicInvoker<int> logic = delegate (int num)
            //{
            //    return num > 2 && num < 8 ? true : false;
            //};
            //LogicInvoker<int> logic = new LogicHolder().Test;

            //Lambda expression: new syntax to wtite anonymous method
            LogicInvoker<int> logicEven = (num) => num % 2 == 0;
            LogicInvoker<int> logicOdd = (num) => num % 2 != 0;
            LogicInvoker<int> logicGreater = (num) => num > 5;

            List<int> result = Filter<int>(dataSource, logicGreater);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            List<Product> products = new List<Product>
            {
                new Product{ Name="dell xps", Id=2, Price=67000, Description="new laptop from dell" },
                new Product{ Name="hp probook", Id=1, Price=43000, Description="new laptop from hp" },
                new Product{ Name="lenovo thinkpad", Id=3, Price=54000, Description="new laptop from lenovo" }
            };
            //products.Sort(new ProductComparison());
            //Comparison<Product> comparisonLogic = delegate (Product x, Product y)
            //{
            //    return x.Name.CompareTo(y.Name);
            //};
            Comparison<Product> comparisonLogic = (x, y) =>
                x.Name.CompareTo(y.Name);
            products.Sort(comparisonLogic);
            //replace null by providing logic through anonymous method written using lambda expression
            //LogicInvoker<Product> logic = (p) => p.Price > 50000;
            LogicInvoker<Product> logic = p => p.Name.Contains('h');
            List<Product> filteredProducts =
                Filter<Product>(products, logic);
            foreach (Product item in filteredProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
