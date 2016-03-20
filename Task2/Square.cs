using System;

namespace Task2
{
    public class Square : Rectangle
    {
        public double Side { get; protected set; }

        public Square(double side) : base(side, side)
        {
            if (side <= 0.0)
                throw new ArgumentOutOfRangeException("side is less then or equal to zero.");
            Side = side;
        }
    }
}
