using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntroExamples
{
    public static class StaticClass
    {
        public static String MyStringMethod(this String s)
        {
            return s.ToUpper();
        }
    }

    class Program
    {
        class Pos
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        class MyClass
        {
            int counter = 0;

            public int Counter
            {
                get { return counter; }
                set
                {
                    if (value > 100)
                        throw new Exception("zu gross!!!!");
                    if (value % 2 == 0)
                        value++;
                    if (counter != value)
                    {
                        counter = value;
                    }
                }
            }

            public int SecondValue { get { return -Counter; } }

            public int ThirdValue { set { Counter = value + 100; } }

            public T Minimum<T>(T a, T b) where T : IComparable
            {
                return (a.CompareTo(b) < 0) ? a : b;
            }

            public String this[String s, DateTime d]
            {
                get { return String.Format("{0} {1}", s, d); }
            }
        }

        static void Main(string[] args)
        {
            // using a try/catch for incrementing a numeric value?

            MyClass c = new MyClass();

            try
            {
                c.Counter++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine();
            // -----------

            // assigning a numeric value to an object?

            Object o = 5;

            Console.WriteLine("o = " + o);

            int i = (int)o;

            Console.WriteLine();
            // -----------

            // untyped variables?

            var j = 17;               
            var s = "Hello World !";  

            var x = new { Name = "Muster", Firstname = "Hans" };

            Console.WriteLine("{0} {1} {2}", j, s, x);

            Console.WriteLine();
            // -----------

            // true or false?

            s = "Test";
            s = s.ToUpper();

            Console.WriteLine(s == "TEST");

            Console.WriteLine();
            // -----------

            // A generic method?

            int a = 5;
            int b = 9;

            int m = c.Minimum<int>(a, b);

            Console.WriteLine("m={0}", m);

            Console.WriteLine();
            // -----------

            // An array indexed with strings and datetime values?
            // And how large is this array?

            for (i = 0; i < 20; i++)
                Console.WriteLine(c["test", DateTime.Now]);

            Console.WriteLine();
            // -----------

            // What is the value of the variable pos1?

            Pos pos1 = new Pos { X = 5, Y = 8 };
            Pos pos2 = pos1;
            pos2.X *= 2;
            pos2.Y *= 2;

            Console.WriteLine("pos1={0},{1}  pos2={2},{3}",
                pos1.X, pos1.Y, pos2.X, pos2.Y);

            Console.WriteLine();
            // -----------

            // Assigning null to an int variable?
            // And what is the value of z?

            int? v = 17;

            v = null;

            int? w = 5;

            int z = v ?? w ?? -1;

            Console.WriteLine("v={0} w={1} z={2}", v, w, z);

            Console.WriteLine();
            // -----------

            // Writing your own method in the String class?

            s = s.MyStringMethod();

            Console.WriteLine("Hello World !".MyStringMethod());

            Console.WriteLine();
            // -----------

            Console.ReadLine();
        }


    }
}
