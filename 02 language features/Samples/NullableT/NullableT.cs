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
            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
