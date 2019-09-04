using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesInCSharp
{
    partial class Form
    {
        private Button button1;
        private void Initialize()
        {
            button1 = new Button();
            button1.Text = "Click Me!!!";
            button1.Name = "button1";
            button1.Size = new Size(20, 30);
            button1.Location = new Point(40, 50);
            button1.Backcolor = Color.Beige;
            //EventHandler handler = new EventHandler(this.ButtonClicked);
            //button1.Click += handler;
            button1.Click += new EventHandler(this.ButtonClicked);
        }
    }
}
