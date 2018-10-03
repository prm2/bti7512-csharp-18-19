using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndIndexers
{
    public class SomeClass
    {
        private int a = -1;
        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B { get; set; }

        public int C { get; set; }

        public int Sum
        {
            get { return A + B + C; }
        }

        public int Global
        {
            set
            {
                A = value;
                B = value;
                C = value;
            }
        }

        int x = -1;
        bool modified = false;

        public int X
        {
            get { return x; }
            set
            {
                if (x != value)
                {
                    if (value > 999)
                        throw new Exception("X > 999 is not allowed!");
                    else
                    {
                        x = value;
                        modified = true;
                    }
                }
            }
        }

        public override string ToString()
        {
            return String.Format("A={0} B={1} C={2} Sum={3}", A, B, C, Sum);
        }
    }

    class Properties
    {
        static void Main(string[] args)
        {
            SomeClass o = new SomeClass();

            Console.WriteLine(o);

            o.A = 2;
            o.B = 4;
            o.C = 6;
            Console.WriteLine(o);

            o.Global = 1;
            Console.WriteLine(o);

            Console.ReadLine();
        }
    }
}
