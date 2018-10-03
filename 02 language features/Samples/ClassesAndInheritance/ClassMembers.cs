using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    public class BaseClass
    {
        int a;              // implicitly private
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        public int f;

        protected static int g;
        protected readonly int h;
        protected static readonly int i = 9;

        protected const int j = 10;

        public BaseClass()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
            f = 6;
            g = 7;
            h = 8;
        }

        public override string ToString()
        {
            return String.Format("a={0} b={1} c={2} d={3} e={4} f={5} g={6} h={7} i={8} j={9}", 
                a, b, c, d, e, f, g, h, i, j);
        }
    }

    public class DerivedClass : BaseClass
    {
        int a;              // implicitly private
        private int b;

        public DerivedClass()
        {
            a = 11;
            b = 12;
            c = 13;
            d = 14;
            e = 15;
            f = 16;
            g = 17;
        }

        public override string ToString()
        {
            return String.Format("a={0} b={1} c={2} d={3} e={4} f={5} g={6} h={7} i={8} j={9}\nBase: {10}", 
                a, b, c, d, e, f, g, h, i, j, base.ToString());
        }
    }
}

