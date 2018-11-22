using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_11_15
{
    public struct ABStruct
    {
        public int A { get; set; }
        public int B { get; set; }

        public ABStruct Correct()
        {
            var h = this;

            if (this.A < 0)
                this.A = 0;
            if (this.B < 0)
                this.B = 0;

            return h;
        }

        public override string ToString()
        {
            return String.Format("A={0} B={1}", A, B);
        }
    }
}
