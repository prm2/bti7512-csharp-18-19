using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_11_15
{
    public delegate int Calculate(int i);

    public static class Static
    {
        public static IEnumerable<int> List(this IEnumerable<int> list)
        {
            yield return 0;

            foreach (var i in list)
                if (i < 0)
                    yield return -i;
                else if (i < 99)
                    yield return i;

            yield return 99;
        }

        public static int Calculate(this int x, Calculate calc)
        {
            return (calc == null) ? 0 : calc(x);
        }

        public static void Convert(ref string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
        }

        public static void Convert(string s1, ref string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
        }
    }
}
