using Task2;
using NUnit.Framework;
using System;

namespace Task2Tests
{
    [TestFixture]
    public class RectangleTests
    {
        private static double eps = 1E-8;

        [Test]
        public void Constructor_WidthAndHeight_CreatedCorrectly()
        {
            //arrange is skiped
            //act
            var rect = new Rectangle(5, 10);

            //assert
            Assert.AreEqual(5, rect.Width,eps);
            Assert.AreEqual(10, rect.Height,eps);
        }

        [Test]
        public void Area_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape rect = new Rectangle(5, 4);

            //act
            double result = rect.Area;

            //assert
            Assert.AreEqual(20.0, result, eps);
        }

        [Test]
        public void Perimeter_Nothing_CalculatedCorrectly()
        {
            //arrange
            Shape rect = new Rectangle(18, 2);

            //act
            double result = rect.Perimeter;

            //assert
            Assert.AreEqual(40.0, result, eps);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WidthLessThenZero_Excpetion()
        {
            //arrange is skiped
            //act
            new Rectangle(-5, 10);

            //assert is handled by exception
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_HeightLessThenZero_Excpetion()
        {
            //arrange is skiped
            //act
            new Rectangle(5, -10);

            //assert is handled by exception
        }
    }


}
