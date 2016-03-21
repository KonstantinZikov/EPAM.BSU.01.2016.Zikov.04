using Task3;
using NUnit.Framework;
using System;

namespace Task3Tests
{
    [TestFixture]
    class CourseTests
    {
        [Test]
        public void Constructor_SomeValues_CreatedCorrectly()
        {
            //arrange
            string name = "Course 1";
            DateTime started = new DateTime(2016, 03, 12);
            DateTime finished = new DateTime(2016, 07, 12);

            //act
            var course = new Course(name, started, finished);

            //assert
            Assert.AreEqual(name, course.Name);
            Assert.AreEqual(started, course.StartDate);
            Assert.AreEqual(finished, course.FinishDate);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_finishDateLessThenStartDate_ArgumentException()
        {
            //arrange
            string name = "Course 1";
            DateTime started = new DateTime(2016, 07, 12);
            DateTime finished = new DateTime(2016, 03, 12);

            //act
            new Course(name, started, finished);

            //assert is handled by exception
        }

        [Test]
        public void Equals_Object_False()
        {
            //arrange
            var c1 = new Course("lol", new DateTime(2016, 03, 12), DateTime.Now);
            var c2 = new object();

            //act
            bool actual = c1.Equals(c2);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void Equals_EqualCourse_True()
        {
            //arrange
            var c1 = new Course("lol", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));
            var c2 = new Course("lol", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));

            //act
            bool actual = c1.Equals(c2);

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_NotEqualCourse_False()
        {
            //arrange
            var c1 = new Course("lol", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));
            var c2 = new Course("lol", new DateTime(2015, 03, 12), new DateTime(2016, 07, 12));

            //act
            bool actual = c1.Equals(c2);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void GetHashCode_Nothing_HashesOfEqualCoursesAreEqual()
        {
            //arrange
            var c1 = new Course("lol", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));
            var c2 = new Course("lol", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));

            //act
            int hash1 = c1.GetHashCode();
            int hash2 = c2.GetHashCode();

            //assert
            Assert.AreEqual(hash1, hash2);
        }

        [Test]
        public void GetHashCode_Nothing_HashesOfNotEqualPersonsAreNotEqual()
        {
            //arrange
            var c1 = new Course("lol", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));
            var c2 = new Course("lol2", new DateTime(2016, 03, 12), new DateTime(2016, 07, 12));

            //act
            int hash1 = c1.GetHashCode();
            int hash2 = c2.GetHashCode();

            //assert
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}
