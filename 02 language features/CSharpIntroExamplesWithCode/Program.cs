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
        interface I3rdDimension
        {
            int Z { get; set; }
        }

        class Pos : I3rdDimension
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
        }

        static void Mirror(Pos p)
        {
            p.X = -p.X;
            p.Y = -p.Y;
        }

        static void Mirror3rdDim(I3rdDimension v)
        {
            v.Z = -v.Z;
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

            // see what happens if you uncomment the following line
            //c.Counter = 100;

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

            i = i + 17; // does not affect the value in 'o'

            Console.WriteLine("o = " + o);

            Console.WriteLine();
            // -----------

            // untyped variables?

            var j = 17;                 // implicit typing: int
            var s = "Hello World !";    // implicit typing: string 

            Console.WriteLine("j is " + j.GetType().Name);
            Console.WriteLine("s is " + s.GetType().Name);

            // anonymous type
            var x = new { Name = "Muster", Firstname = "Hans" };

            Console.WriteLine("x is " + x.GetType().Name);

            Console.WriteLine("{0} {1} {2}", j, s, x);

            Console.WriteLine();
            // -----------

            // true or false?

            s = "Test";
            s = s.ToUpper();

            // is true because the string type overwrites the == operator
            // and effectively calls the .Equals method
            Console.WriteLine(s == "TEST");

            Console.WriteLine();
            // -----------

            // A generic method?

            int a = 5;
            int b = 9;

            int m = c.Minimum<int>(a, b);

            Console.WriteLine();
            // -----------

            // An array indexed with strings and datetime values?
            // And how large is this array?

            for (i = 0; i < 2; i++)
                Console.WriteLine(c["test", DateTime.Now]);

            // Example: Dictionary uses the indexer to get a value by key
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(5, "Fuenf");

            s = dict[5];
            Console.WriteLine();

            // -----------

            // What is the value of the variable pos1?

            // observe the difference when Pos is declared as a class vs struct
            Pos pos1 = new Pos { X = 5, Y = 8 };
            Pos pos2 = pos1;
            pos2.X *= 2;
            pos2.Y *= 2;

            Console.WriteLine("pos1={0},{1}  pos2={2},{3}",
                pos1.X, pos1.Y, pos2.X, pos2.Y);

            Mirror(pos1);
            Console.WriteLine("pos1={0},{1}  pos2={2},{3}",
                pos1.X, pos1.Y, pos2.X, pos2.Y);

            pos1.Z = 99;
            Console.WriteLine("pos1={0},{1},{2}", pos1.X, pos1.Y, pos1.Z);
            Mirror3rdDim(pos1);
            Console.WriteLine("pos1={0},{1},{2}", pos1.X, pos1.Y, pos1.Z);

            // with class:
            //   pos1 = 5,8  pos2 = 10,16
            //   pos1 = 5,8  pos2 = 10,16
            //   pos1 = 5,8,99
            //   pos1 = 5,8,99

            // with struct:
            //   pos1 = 10,16  pos2 = 10,16
            //   pos1 = -10,-16  pos2 = -10,-16
            //   pos1 = -10,-16,99
            //   pos1 = -10,-16,-99

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
