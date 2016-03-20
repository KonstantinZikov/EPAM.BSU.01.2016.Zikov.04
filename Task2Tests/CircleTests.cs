using Task2;
using NUnit.Framework;
using static System.Math;
using System;

namespace Task2Tests
{
    [TestFixture]
    class CircleTests
    {
        private static double eps = 1E-8;

        [Test]
        public void Constructor_Radius_CreatedCorrectly()
        {
            //arrange is skiped
            //act
            var circle = new Circle(5);

            //assert
            Assert.AreEqual(5, circle.A, eps);
            Assert.AreEqual(5, circle.B, eps);
            Assert.AreEqual(5, circle.Radius, eps);
        }

        [Test]
        public void Perimeter_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape circle = new Circle(5);

            //act
            double result = circle.Perimeter;

            //assert
            Assert.AreEqual(PI*5*2, result, eps);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_RadiusLessThenZero_Excpetion()
        {
            //arrange is skiped
            //act
            new Circle(-5);

            //assert is handled by exception
        }

    }
}
