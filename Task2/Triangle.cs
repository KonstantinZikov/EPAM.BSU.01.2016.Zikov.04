using System;

namespace Task2
{
    public class Triangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0.0)
                throw new ArgumentOutOfRangeException("a is less then or equal to zero.");
            if (b <= 0.0)
                throw new ArgumentOutOfRangeException("b is less then or equal to zero.");
            if (c <= 0.0)
                throw new ArgumentOutOfRangeException("c is less then or equal to zero.");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("The sum of two sides less then or equal to third side.");
            A = a;
            B = b;
            C = c;
        }

        public override double Area
        {
            get
            {
                double p = Perimeter/2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public override double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }
    }
}
