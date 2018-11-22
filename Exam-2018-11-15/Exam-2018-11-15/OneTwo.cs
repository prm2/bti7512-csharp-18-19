using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_11_15
{
    public class Alpha
    {
        public virtual string Write()
        {
            return "Alpha.Write";
        }

        public string Display()
        {
            return "Alpha.Display";
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.Write(), this.Display());
        }
    }

    public class Beta : Alpha
    {
        public override string Write()
        {
            return "Beta.Write";
        }

        public new string Display()
        {
            return "Beta.Display";
        }
    }
}
