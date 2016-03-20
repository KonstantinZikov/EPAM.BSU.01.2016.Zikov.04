using System;
using static System.Math;

namespace Task2
{
    public class Circle : Ellipse
    {
        public double Radius { get; private set; }

        public Circle(double radius):base(radius,radius)
        {
            if (radius <= 0.0)
                throw new ArgumentOutOfRangeException("radius is less then or equal to zero.");
            Radius = radius;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * PI * Radius;
            }
        }
    }
}
