using Task2;
using NUnit.Framework;
using System;

namespace Task2Tests
{
    [TestFixture]
    public class EllipseTests
    {
        private static double eps = 1E-2;

        [Test]
        public void Constructor_AandB_CreatedCorrectly()
        {
            //arrange is skiped
            //act
            var ellipse = new Ellipse(3.5, 4);

            //assert
            Assert.AreEqual(3.5, ellipse.A, eps);
            Assert.AreEqual(4, ellipse.B, eps);
        }

        [Test]
        public void Area_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape ellipse = new Ellipse(5, 4);

            //act
            double result = ellipse.Area;

            //assert
            Assert.AreEqual(62.832, result, eps);
        }

        [Test]
        public void Perimeter_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape ellipse = new Ellipse(5, 4);

            //act
            double result = ellipse.Perimeter;

            //assert
            Assert.AreEqual(28.369, result, eps);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ALessThenZero_Excpetion()
        {
            //arrange is skiped
            //act
            var rect = new Ellipse(-5, 10);

            //assert is handled by exception
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_BLessThenZero_Excpetion()
        {
            //arrange is skiped
            //act
            var rect = new Ellipse(5, -10);

            //assert is handled by exception
        }
    }
}
