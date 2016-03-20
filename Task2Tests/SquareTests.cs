using Task2;
using NUnit.Framework;
using System;

namespace Task2Tests
{
    [TestFixture]
    class SquareTests
    {
        private static double eps = 1E-8;

        [Test]
        public void Constructor_Side_CreatedCorrectly()
        {
            //arrange is skiped
            //act
            var square = new Square(5);

            //assert
            Assert.AreEqual(5, square.Width, eps);
            Assert.AreEqual(5, square.Height, eps);
            Assert.AreEqual(5, square.Side, eps);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_SideLessThenZero_Excpetion()
        {
            //arrange is skiped
            //act
            new Square(-5);

            //assert is handled by exception
        }
    }
}
