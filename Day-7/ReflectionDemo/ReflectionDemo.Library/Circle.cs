//using System;
using static System.Math;
//using static System.Console;

namespace ReflectionDemo.Library
{
    public class Circle : IShape
    {
        private double _radius;
        public Circle()
        {
           
        }
        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double Radius { get => _radius; set => _radius = value; }
        public double CalculateArea()
        {
            return PI * _radius * _radius;
        }
    }
}
