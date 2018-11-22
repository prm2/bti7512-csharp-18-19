using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2018_11_15
{
    class Program
    {
        static void A()
        {
            Console.WriteLine(" A ");
            Console.WriteLine("---");

            // 4 ref params
            var s1 = "Hello";
            var s2 = "World";
            Static.Convert(ref s1, s2);
            Console.WriteLine("{0} {1}", s1, s2);
            var s3 = "Bern";
            Static.Convert(s3, ref s3);
            Console.WriteLine(s3);

            // 8 struct
            var p = new ABStruct { A = 2, B = -2 };
            var q = p;
            q.Correct();
            Console.WriteLine("p:{0} / q:{1}", p, q);
            var r = new ABStruct();
            r.A = -5;
            r.B = -5;
            q = r.Correct();
            Console.WriteLine("q:{0} / r:{1}", q, r);
            r = new ABStruct { A = 7, B = 7 };
            r.A++;
            r.B--;
            Console.WriteLine(r);
            object obj = new ABStruct { A = 0, B = 0 };
            p = (ABStruct)obj;
            p.A++;
            p.B++;
            Console.WriteLine(obj);

            // 6 Lambdas
            int s = 6;
            Console.WriteLine(s.Calculate(j => j * 2));
            Calculate c = (j => 1 - j);
            Console.WriteLine(s.Calculate(c).Calculate(c));
            c += (j) => -j;
            Console.WriteLine(5.Calculate(c));

            // 10 Properties + Indexers
            var x = new XY { X = 1, Y = -3 };
            Console.WriteLine(x);
            for (var k = 0; k < 5; k++)
                Console.Write("{0}, ", x[k]);
            Console.WriteLine();
            var y = new XY { S = 5 };
            Console.WriteLine(y);
            var z = new XY { X = -5, Y = 5 };
            z.X++;
            z.Y++;
            Console.WriteLine(z);

            // 10 Nullable<T>
            int? m = null;
            int? n = null;
            object o = m ?? -1;
            Console.WriteLine("o={0} m={1}", o, m);
            o = 5;
            m = (int)o;
            Console.WriteLine("o={0} m={1}", o, m);
            Console.WriteLine(n ?? m ?? 0);
            m = 7;
            o = m;
            o = (int)o * 2;
            Console.WriteLine("o={0} m={1}", o, m);
            n = 3;
            Console.WriteLine("{0} -> {1}", n, n.Value * 3);

            // 8 virtualization
            Alpha a = new Beta();
            Console.WriteLine((Beta)a);
            Console.WriteLine(((Beta)a).Display());
            Console.WriteLine(a.Display());
            Console.WriteLine(a.Write());

            // 4 yielding
            int[] numbers = new int[] { 10, -12, 192, -200, 81, 51, -81 };
            foreach (var i in numbers.List())
                Console.Write($"{i}  ");
            Console.WriteLine();
            foreach (var i in numbers.List().List())
                Console.Write($"{i}  ");
            Console.WriteLine();
        }

        static void B()
        {
            Console.WriteLine(" B ");
            Console.WriteLine("---");
            var p = new ABStruct { A = 3, B = -2 };
            var q = p;
            q.Correct();
            Console.WriteLine("p:{0} / q:{1}", p, q);

            var r = new ABStruct();
            r.A = -4;
            r.B = -4;
            q = r.Correct();
            Console.WriteLine("q:{0} / r:{1}", q, r);

            r = new ABStruct { A = 5, B = 5 };
            r.A++;
            r.B--;
            Console.WriteLine(r);

            object obj = new ABStruct { A = 2, B = 2 };
            p = (ABStruct)obj;
            p.A++;
            p.B++;
            Console.WriteLine(obj);

            int s = 4;
            Console.WriteLine(s.Calculate(j => j * 2));

            Calculate c = (j => 1 - j);
            Console.WriteLine(s.Calculate(c).Calculate(c));

            c += (j) => -j;
            Console.WriteLine(7.Calculate(c));


            Console.WriteLine("---");

            var x = new XY { X = 1, Y = -4 };
            Console.WriteLine(x);

            for (var k = 0; k < 5; k++)
                Console.Write("{0}, ", x[k]);
            Console.WriteLine();

            var y = new XY { S = 7 };
            Console.WriteLine(y);

            var z = new XY { X = -3, Y = 3 };
            z.X++;
            z.Y++;
            Console.WriteLine(z);

            int? m = null;
            int? n = null;
            object o = m ?? -3;
            Console.WriteLine("o={0} m={1}", o, m);

            o = 7;
            m = (int)o;
            Console.WriteLine("o={0} m={1}", o, m);

            Console.WriteLine(n ?? m ?? 0);

            m = 3;
            o = m;
            o = (int)o * 3;
            Console.WriteLine("o={0} m={1}", o, m);

            Console.WriteLine("---");

            n = 2;
            Console.WriteLine("{0} -> {1}", n, n.Value * 3);

            Alpha a = new Beta();
            Console.WriteLine((Beta)a);

            Console.WriteLine(((Beta)a).Display());

            Console.WriteLine(a.Display());

            Console.WriteLine(a.Write());

            int[] numbers = new int[] { 12, -10, 166, -250, 51, 81, -51 };
            foreach (var i in numbers.List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            foreach (var i in numbers.List().List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            var s1 = "Good";
            var s2 = "Evening";
            Static.Convert(s1, ref s2);
            Console.WriteLine("{0} {1}", s1, s2);

            var s3 = "Biel";
            Static.Convert(ref s3, s3);
            Console.WriteLine(s3);

        }

        static void C()
        {
            Console.WriteLine(" C ");
            Console.WriteLine("---");
            int s = 6;
            Console.WriteLine(s.Calculate(j => j * 3));

            Calculate c = (j => 1 - j);
            Console.WriteLine(s.Calculate(c).Calculate(c));

            c += (j) => -j;
            Console.WriteLine(8.Calculate(c));

            var x = new XY { X = 2, Y = -5 };
            Console.WriteLine(x);

            for (var k = 0; k < 5; k++)
                Console.Write("{0}, ", x[k]);
            Console.WriteLine();

            var y = new XY { S = 8 };
            Console.WriteLine(y);

            var z = new XY { X = -7, Y = 7 };
            z.X++;
            z.Y++;
            Console.WriteLine(z);

            int? m = null;
            int? n = null;
            object o = m ?? -1;
            Console.WriteLine("o={0} m={1}", o, m);

            Console.WriteLine("---");

            o = 3;
            m = (int)o;
            Console.WriteLine("o={0} m={1}", o, m);

            Console.WriteLine(n ?? m ?? 0);

            m = 5;
            o = m;
            o = (int)o * 2;
            Console.WriteLine("o={0} m={1}", o, m);

            n = 2;
            Console.WriteLine("{0} -> {1}", n, n.Value * 4);

            Alpha a = new Beta();
            Console.WriteLine((Beta)a);

            Console.WriteLine(((Beta)a).Display());

            Console.WriteLine(a.Display());

            Console.WriteLine(a.Write());

            int[] numbers = new int[] { 10, -12, -192, 200, 71, 42, -71 };
            foreach (var i in numbers.List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            Console.WriteLine("---");

            foreach (var i in numbers.List().List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            var s1 = "Guten";
            var s2 = "Tag";
            Static.Convert(ref s1, s2);
            Console.WriteLine("{0} {1}", s1, s2);

            var s3 = "Rolex";
            Static.Convert(s3, ref s3);
            Console.WriteLine(s3);

            var p = new ABStruct { A = 4, B = -3 };
            var q = p;
            q.Correct();
            Console.WriteLine("p:{0} / q:{1}", p, q);

            var r = new ABStruct();
            r.A = -6;
            r.B = -6;
            q = r.Correct();
            Console.WriteLine("q:{0} / r:{1}", q, r);

            r = new ABStruct { A = 3, B = 3 };
            r.A++;
            r.B--;
            Console.WriteLine(r);

            object obj = new ABStruct { A = 4, B = 4 };
            p = (ABStruct)obj;
            p.A++;
            p.B++;
            Console.WriteLine(obj);
        }

        static void F()
        {
            Console.WriteLine(" F ");
            Console.WriteLine("---");

            var p = new ABStruct { A = 2, B = -2 };
            var q = p;
            q.Correct();
            Console.WriteLine("p:{0} / q:{1}", p, q);

            var r = new ABStruct();
            r.A = -5;
            r.B = -5;
            q = r.Correct();
            Console.WriteLine("q:{0} / r:{1}", q, r);

            r = new ABStruct { A = 7, B = 7 };
            r.A++;
            r.B--;
            Console.WriteLine(r);

            object obj = new ABStruct { A = 0, B = 0 };
            p = (ABStruct)obj;
            p.A++;
            p.B++;
            Console.WriteLine(obj);

            int[] numbers = new int[] { 10, -12, 192, -200, 81, 51, -81 };
            foreach (var i in numbers.List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            foreach (var i in numbers.List().List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            int s = 6;
            Console.WriteLine(s.Calculate(j => j * 2));

            Console.WriteLine("---");

            Calculate c = (j => 1 - j);
            Console.WriteLine(s.Calculate(c).Calculate(c));

            c += (j) => -j;
            Console.WriteLine(5.Calculate(c));

            var x = new XY { X = 1, Y = -3 };
            Console.WriteLine(x);

            for (var k = 0; k < 5; k++)
                Console.Write("{0}, ", x[k]);
            Console.WriteLine();

            var y = new XY { S = 5 };
            Console.WriteLine(y);

            var z = new XY { X = -5, Y = 5 };
            z.X++;
            z.Y++;
            Console.WriteLine(z);

            int? m = null;
            int? n = null;
            object o = m ?? -1;
            Console.WriteLine("o={0} m={1}", o, m);

            o = 5;
            m = (int)o;
            Console.WriteLine("o={0} m={1}", o, m);

            Console.WriteLine("---");

            Console.WriteLine(n ?? m ?? 0);

            m = 7;
            o = m;
            o = (int)o * 2;
            Console.WriteLine("o={0} m={1}", o, m);

            n = 3;
            Console.WriteLine("{0} -> {1}", n, n.Value * 3);

            Alpha a = new Beta();
            Console.WriteLine((Beta)a);

            Console.WriteLine(((Beta)a).Display());

            Console.WriteLine(a.Display());

            Console.WriteLine(a.Write());

            var s1 = "Hello";
            var s2 = "World";
            Static.Convert(ref s1, s2);
            Console.WriteLine("{0} {1}", s1, s2);

            var s3 = "Bienne";
            Static.Convert(s3, ref s3);
            Console.WriteLine(s3);
        }

        static void G()
        {
            Console.WriteLine(" G ");
            Console.WriteLine("---");

            var p = new ABStruct { A = 2, B = -2 };
            var q = p;
            q.Correct();
            Console.WriteLine("p:{0} / q:{1}", p, q);

            var r = new ABStruct();
            r.A = -5;
            r.B = -5;
            q = r.Correct();
            Console.WriteLine("q:{0} / r:{1}", q, r);

            r = new ABStruct { A = 7, B = 7 };
            r.A++;
            r.B--;
            Console.WriteLine(r);

            object obj = new ABStruct { A = 0, B = 0 };
            p = (ABStruct)obj;
            p.A++;
            p.B++;
            Console.WriteLine(obj);

            int[] numbers = new int[] { 10, -12, 192, -200, 81, 51, -81 };
            foreach (var i in numbers.List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            foreach (var i in numbers.List().List())
                Console.Write($"{i}  ");
            Console.WriteLine();

            int s = 6;
            Console.WriteLine(s.Calculate(j => j * 2));

            Console.WriteLine("---");

            Calculate c = (j => 1 - j);
            Console.WriteLine(s.Calculate(c).Calculate(c));

            c += (j) => -j;
            Console.WriteLine(5.Calculate(c));

            var x = new XY { X = 1, Y = -3 };
            Console.WriteLine(x);

            for (var k = 0; k < 5; k++)
                Console.Write("{0}, ", x[k]);
            Console.WriteLine();

            var y = new XY { S = 5 };
            Console.WriteLine(y);

            var z = new XY { X = -5, Y = 5 };
            z.X++;
            z.Y++;
            Console.WriteLine(z);

            int? m = null;
            int? n = null;
            object o = m ?? -1;
            Console.WriteLine("o={0} m={1}", o, m);

            o = 5;
            m = (int)o;
            Console.WriteLine("o={0} m={1}", o, m);

            Console.WriteLine("---");

            Console.WriteLine(n ?? m ?? 0);

            m = 7;
            o = m;
            o = (int)o * 2;
            Console.WriteLine("o={0} m={1}", o, m);

            n = 3;
            Console.WriteLine("{0} -> {1}", n, n.Value * 3);

            Alpha a = new Beta();
            Console.WriteLine((Beta)a);

            Console.WriteLine(((Beta)a).Display());

            Console.WriteLine(a.Display());

            Console.WriteLine(a.Write());

            var s1 = "Hello";
            var s2 = "World";
            Static.Convert(ref s1, s2);
            Console.WriteLine("{0} {1}", s1, s2);

            var s3 = "Bienne";
            Static.Convert(s3, ref s3);
            Console.WriteLine(s3);
        }

        static void Problem2()
        {
            var data = new List<ABStruct>
            {
                new ABStruct { A = 4, B = 2 },
                new ABStruct { A = 1000, B = 2000 }
            };
            var res1 = data.Where(d => d.A > 2);
            var res2 = res1.OrderBy(d => d.A).LastOrDefault();
            var res3 = res1.Select(d => new { A = -d.A, B = -d.B }).ToList();
            var res4 = res1.Where(d => d.A > 999).Select(d => d.B).FirstOrDefault();
            var res5 = res3.FirstOrDefault();

            Console.WriteLine("False (it is a struct and thus a value, not a reference");
            Console.WriteLine(res5 is ABStruct);
            Console.WriteLine(res4 is IEnumerable<ABStruct>);
            Console.WriteLine(res4 == null);
            Console.WriteLine(res1 is IEnumerable<ABStruct>);
            Console.WriteLine(Test(res5));
            Console.WriteLine(res1 is List<ABStruct>);
            Console.WriteLine(res4 is ABStruct);
        }

        static bool Test<T>(T t) where T:class
        {
            return true;
        }

        static void Main(string[] args)
        {
            //A();
            //B();
            //C();
            //F();
            //G();

            Problem2();

            Console.ReadLine();
        }
    }
}
