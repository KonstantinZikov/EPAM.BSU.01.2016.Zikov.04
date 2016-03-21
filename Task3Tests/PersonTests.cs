using Task3;
using NUnit.Framework;
using System;

namespace Task3Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Constructor_SomeValues_CreatedCorrectly()
        {
            //arrange
            string name = "John";
            string surname = "Smith";
            DateTime date = new DateTime(1995, 1, 1);

            //act
            var person = new Person(name, surname, date);

            //assert
            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(surname, person.Surname);
            Assert.AreEqual(date, person.DateOfBirth);
        }

        [Test]
        public void Equals_Object_False()
        {
            //arrange
            var p1 = new Person("lol","lol",DateTime.Now);
            var p2 = new object();

            //act
            bool actual = p1.Equals(p2);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void Equals_EqualPerson_True()
        {
            //arrange
            var p1 = new Person("lol", "lol", new DateTime(1995, 2, 2));
            var p2 = new Person("lol", "lol", new DateTime(1995, 2, 2));

            //act
            bool actual = p1.Equals(p2);

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_NotEqualPerson_False()
        {
            //arrange
            var p1 = new Person("lol", "lol", new DateTime(1995, 2, 2));
            var p2 = new Person("lol", "lol", new DateTime(1995, 2, 3));

            //act
            bool actual = p1.Equals(p2);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void GetHashCode_Nothing_HashesOfEqualPersonsAreEqual()
        {
            //arrange
            var p1 = new Person("lol", "lol", new DateTime(1995, 2, 2));
            var p2 = new Person("lol", "lol", new DateTime(1995, 2, 2));

            //act
            int hash1 = p1.GetHashCode();
            int hash2 = p2.GetHashCode();

            //assert
            Assert.AreEqual(hash1,hash2);
        }

        [Test]
        public void GetHashCode_Nothing_HashesOfNotEqualPersonsAreNotEqual()
        {
            //arrange
            var p1 = new Person("lol", "lol", new DateTime(1995, 2, 2));
            var p2 = new Person("lol", "lol", new DateTime(1995, 2, 3));

            //act
            int hash1 = p1.GetHashCode();
            int hash2 = p2.GetHashCode();

            //assert
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}
