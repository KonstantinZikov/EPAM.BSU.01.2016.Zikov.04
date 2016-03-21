using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Mark : IEquatable<Mark>
    {
        private int value;
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Value can be only in range [1,10].");
                }
                this.value = value;
            }
        }
        public Course Course { get; set; }
        public Person Student { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Mark);
        }

        public bool Equals(Mark mark)
        {
            if (ReferenceEquals(mark, this)) return true;
            if (ReferenceEquals(mark, null)) return false;
            if (GetType() != mark.GetType()) return false;
            if (Value == mark.Value &&
                Course.Equals(mark.Course) &&
                Student.Equals(mark.Student))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value ^ Course.GetHashCode() ^ Student.GetHashCode();
        }
    }
}
