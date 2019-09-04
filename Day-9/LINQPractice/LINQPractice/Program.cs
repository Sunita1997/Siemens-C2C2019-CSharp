using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main()
        {
            string[] locations = new string[] { "Mumbai", "Pune", "Bangalore", "Mangalore", "Chennai" };

            var query
                = from location in locations
                  orderby location descending
                  group location by location[0] into g
                  select new
                  {
                      ItemsKey = g.Key,
                      Items = (from l in g
                               orderby l ascending
                               select l)
                  };

            foreach (var item in query)
            {
                Console.WriteLine($"locations starting with {item.ItemsKey}");
                Console.WriteLine("-----------------------------");
                foreach (string name in item.Items)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            IEnumerable<IGrouping<char, string>> methodQuery =
                locations
                .OrderByDescending(location => location)
                .GroupBy(location => location[0]);
            foreach (IGrouping<char, string> group in methodQuery)
            {
                Console.WriteLine($"locations starting with {group.Key}");
                Console.WriteLine("--------------------------------------");

                foreach (string locationName in group)
                {
                    Console.WriteLine(locationName);
                }
            }
            /*
             * locations starting with P
             * ---------------------------
             * Pune
             * 
             * locations starting with M
             * ---------------------------
             *  Mumbai
             *  Mangalore
             * 
             * locations starting with C
             * ---------------------------
             * Chennai
             * 
             * locations starting with B
             * ---------------------------
             * Bangalore
             */
        }
    }
}
