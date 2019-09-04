using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesInCSharp
{
    partial class Sample
    {
        partial void Test()
        {
            Console.WriteLine("partial test method");
        }
        public void Foo()
        {
            Console.WriteLine("Foo");
            Test();
        }
    }
}
