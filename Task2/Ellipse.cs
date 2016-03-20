using System;
using static System.Math;

namespace Task2
{
    public class Ellipse : Shape
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        public Ellipse(double a, double b)
        {
            if (a <= 0.0)
                throw new ArgumentOutOfRangeException("a is less then or equal to zero.");
            if (b <= 0.0)
                throw new ArgumentOutOfRangeException("b is less then or equal to zero.");
            A = a;
            B = b;
        }

        public override double Area
        {
            get
            {
                return PI * A * B;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 4 * ((PI * A * B + Pow(A - B, 2)) / (A + B));
            }
        }
    }
}
