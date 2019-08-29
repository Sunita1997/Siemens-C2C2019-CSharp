using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNewFetaures_v2
{
    delegate string TestDel(string val);
    class Program
    {
        static void Main()
        {
            //anonymous method
            TestDel del = delegate (string name)
            {
                return "hello " + name;
            };
            string message = del("joydip");
            Console.WriteLine(message);
        }
    }
}
