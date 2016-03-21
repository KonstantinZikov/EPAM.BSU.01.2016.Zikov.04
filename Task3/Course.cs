using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Course
    {
        public string Name { get; private set; }
        private List<Person> students = new List<Person>();
        public List<Person> Students
        {
            get
            {
                return new List<Person>(students);
            }
        }
        private List<Person> trainers = new List<Person>();
        public List<Person> Trainers
        {
            get
            {
                return new List<Person>(trainers);
            }
        }
        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; }
        public bool IsStarted { get { return (DateTime.Now > StartDate); } }
        public bool IsFinished { get { return (DateTime.Now > FinishDate); } }

        public Course(string name, DateTime startDate, DateTime finishDate)
        {
            if (startDate >= finishDate)
            {
                throw new ArgumentException("finishDate must bew greater then startDate.");
            }
            Name = name;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public void AddStudent(Person student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student is null.");
            }
            if (students.Find((st) => st.Equals(student)) != null)
                throw new ArgumentException("This student has already been added.");
            students.Add(student);
        }

        public bool RemoveStudent(Person student)
        {
            return students.Remove(students.Find((st)=>st.Equals(student)));
        }

        public void AddTrainer(Person trainer)
        {
            if (trainer == null)
            {
                throw new ArgumentNullException("trainer is null.");
            }
            if (trainers.Find((tr) => tr.Equals(trainer)) != null)
                throw new ArgumentException("This trainer has already been added.");
            trainers.Add(trainer);
        }

        public bool RemoveTrainer(Person trainer)
        {
            return trainers.Remove(trainers.Find((tr) => tr.Equals(trainer)));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Course);
        }

        public bool Equals(Course cource)
        {
            if (ReferenceEquals(cource, this)) return true;
            if (ReferenceEquals(cource, null)) return false;
            if (GetType() != cource.GetType()) return false;
            if (Name == cource.Name &&
                StartDate == cource.StartDate &&
                FinishDate == cource.FinishDate)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ StartDate.GetHashCode() ^ FinishDate.GetHashCode();
        }

    }
}
