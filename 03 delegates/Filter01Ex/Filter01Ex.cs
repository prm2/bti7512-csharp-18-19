using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFH
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Write functionality that allows to define subsets of
            //       objects or values out of given sets.
            //       The functionality has to be generic in two senses:
            //       1) Works for all datatypes
            //       2) Allows to specify arbitrary filter conditions

            var numbers = Numbers.GetNumbers(); // TODO: Define a subset of numbers
            Console.WriteLine("filtered numbers:");
            foreach (var n in numbers)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.WriteLine();

            var john = Person.GetPersons(); // TODO: Define a subset of persons
            Console.WriteLine("searching John:");
            foreach (var p in john)
                Console.WriteLine(p);
            Console.WriteLine();

            var bigRect = Rectangle.GetRectangles(); // TODO: Define a subset of rectangles
            Console.WriteLine("Rectangles with area > 100:");
            foreach (var r in bigRect)
                Console.WriteLine(r);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
