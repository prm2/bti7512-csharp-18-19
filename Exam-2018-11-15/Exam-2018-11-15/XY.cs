using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_11_15
{
    public class XY
    {
        private int x;
        private int y;

        public int X
        {
            set { x = value; }
            get { return (x < 0) ? -x : x; }
        }

        public int Y
        {
            set { y = value; }
            get { return (y > 0) ? -y : y; }
        }

        public int S
        {
            get { return y + x; }
            set
            {
                x = value;
                y = value;
            }
        }

        public int this[int i]
        {
            get { return (i % 2 == 0) ? x : y; }
        }

        public override string ToString()
        {
            return $"X={X} Y={Y}";
        }
    }
}
