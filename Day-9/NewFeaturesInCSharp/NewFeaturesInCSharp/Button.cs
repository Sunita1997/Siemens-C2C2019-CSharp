using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesInCSharp
{
    class Button
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public event EventHandler Click;
        public Size Size { get; set; }
        public Point Location { get; set; }
        public Color Backcolor { get; set; }
    }
}
