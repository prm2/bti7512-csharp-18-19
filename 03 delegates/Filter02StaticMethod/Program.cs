using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFH
{
    class Program
    {
        public static bool IsEven(int i)
        {
            return (i % 2 == 0);
        }

        public static bool Rect100(Rectangle rect)
        {
            return (rect.Height * rect.Width) > 100.0;
        }


        static void Main(string[] args)
        {
            // Define a subset of numbers
            var numbers = GenericFilter.GetSubset<int>(Numbers.GetNumbers(), IsEven);

            Console.WriteLine("even numbers:");
            foreach (var n in numbers)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.WriteLine();

            // Define a subset of rectangles
            var bigRect = GenericFilter.GetSubset(Rectangle.GetRectangles().ToArray(), Rect100); 
            Console.WriteLine("Rectangles with area > 100:");
            foreach (var r in bigRect)
                Console.WriteLine(r);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
