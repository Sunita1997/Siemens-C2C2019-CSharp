using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main()
        {
            Assistant charles = new Assistant();
            Trainer joydip = new Trainer(charles);
            string facility = joydip.GetFacility();
            Console.WriteLine(facility);

            List<int> numbers = new List<int> { };
        }
    }
}
