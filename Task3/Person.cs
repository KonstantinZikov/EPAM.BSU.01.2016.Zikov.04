using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   public class Person : IEquatable<Person>
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person person)
        {
            if (ReferenceEquals(person, this)) return true;
            if (ReferenceEquals(person, null)) return false;
            if (GetType() != person.GetType()) return false;
            if (Name == person.Name &&
                Surname == person.Surname &&
                DateOfBirth == person.DateOfBirth)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Surname.GetHashCode() ^ DateOfBirth.GetHashCode();
        }
    }
}
