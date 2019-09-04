using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesInCSharp
{
    //Partial types
    partial class Form
    {
        public Form()
        {
            Initialize();
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
        }
    }
}
