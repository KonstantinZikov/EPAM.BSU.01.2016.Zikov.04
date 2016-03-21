using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Archive
    {
        private List<Mark> marks = new List<Mark>();
        public List<Mark> Marks
        {
            get
            {
                return new List<Mark>(marks);
            }
        }

        public void AddMark(Mark mark)
        {
            marks.Add(mark);
        }

        public bool RemoveMark(Mark mark)
        {
            return marks.Remove(mark);
        }
    }
}
