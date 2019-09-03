using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConcept
{
    class Calculation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
