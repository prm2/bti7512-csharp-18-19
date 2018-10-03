using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFH.Prm1.Extensions1
{
    public static class Extensions1
    {
        public static string MyMethod(this string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('-');
            foreach (var c in s)
            {
                sb.Append(c);
                sb.Append('-');
            }
            return sb.ToString();
        }
    }
}
