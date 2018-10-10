using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableT
{
    class TestClass
    {
       
        public int X { get; set; }
        public int Y { get; set; }
        public void SomeMethod()
        {
            Console.WriteLine($"TestClass.SomeMethod X={X} Y={Y}");
        }
    }

    struct TestStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void SomeMethod()
        {
            Console.WriteLine($"TestClass.SomeMethod X={X} Y={Y}");
        }
    }


    class NullableT
    {
        static void Main(string[] args)
        {
            int? i = null;

            Console.WriteLine((i ?? 17).GetType().Name);

            if (i == null)
                Console.WriteLine("i is null");
            else
                Console.WriteLine(i);

            if (!i.HasValue)
                Console.WriteLine("i is null");
            else
                Console.WriteLine(i.Value);

            TestClass tc = null;
            TestStruct? ts = null;


            ts?.SomeMethod();
            tc?.SomeMethod();

            int j = ts?.X ?? 17;

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
