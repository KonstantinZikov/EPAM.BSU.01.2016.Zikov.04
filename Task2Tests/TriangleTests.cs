using Task2;
using NUnit.Framework;
using System;

namespace Task2Tests
{
    [TestFixture]
    class TriangleTests
    {
        private static double eps = 1E-8;

        [Test]
        public void Constructor_ABC_CreatedCorrectly()
        {
            //arrange is skiped
            //act
            var triangle = new Triangle(5, 10, 12);

            //assert
            Assert.AreEqual(5, triangle.A, eps);
            Assert.AreEqual(10, triangle.B, eps);
            Assert.AreEqual(12, triangle.C, eps);
        }

        [Test]
        public void Area_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape triangle = new Triangle(3, 4, 5);

            //act
            double result = triangle.Area;

            //assert
            Assert.AreEqual(6, result, eps);
        }

        [Test]
        public void Perimeter_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape triangle = new Triangle(3, 4, 5);

            //act
            double result = triangle.Perimeter;

            //assert
            Assert.AreEqual(12, result, eps);
        }

        [TestCase(-4,3,2)]
        [TestCase(4, -3, 2)]
        [TestCase(4, 3, -2)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_SideLessThenZero_Excpetion(double a, double b, double c)
        {
            //arrange is skiped
            //act
            new Triangle(a,b,c);

            //assert is handled by exception
        }

        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_IncorrectSides_Exception()
        {
            //arrange is skiped
            //act
            new Triangle(1, 2, 3);

        //assert is handled by exception
    }
}
}
