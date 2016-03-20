using System;

namespace Task2
{
    public class Rectangle : Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Rectangle(double width, double height)
        {
            if (width <= 0.0)
                throw new ArgumentOutOfRangeException("width is less then or equal to zero.");
            if (height <= 0.0)
                throw new ArgumentOutOfRangeException("height is less then or equal to zero.");
            Width = width;
            Height = height;
        }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public override double Perimeter
        {
            get
            {
                return (Width + Height)*2;
            }
        }
    }
}
