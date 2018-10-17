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

        public class FirstNameFilter : GenericFilter<Person>
        {
            string name;

            public FirstNameFilter(string name)
            {
                this.name = name;
            }
            
            private bool Filter(Person pers)
            {
                return (pers.FirstName == this.name);
            }

            public IEnumerable<Person> GetSubset(Person[] src)
            {
                return this.GetSubset(src, this.Filter);
            }
        }

        public static bool Rect100(Rectangle rect)
        {
            return (rect.Height * rect.Width) > 100.0;
        }

        static void Main(string[] args)
        {
            // Define a subset of numbers
            var filter = new GenericFilter<int>();
            var numbers = filter.GetSubset(Numbers.GetNumbers(), IsEven);

            Console.WriteLine("even numbers:");
            foreach (var n in numbers)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.WriteLine();

            // Define a subset of persons
            var john = (new FirstNameFilter("John"))
                .GetSubset(Person.GetPersons()); 
            Console.WriteLine("searching John:");
            foreach (var p in john)
                Console.WriteLine(p);
            Console.WriteLine();

            // Define a subset of rectangles
            var bigRect = (new GenericFilter<Rectangle>())
                .GetSubset(Rectangle.GetRectangles().ToArray(), Rect100); 
            Console.WriteLine("Rectangles with area > 100:");
            foreach (var r in bigRect)
                Console.WriteLine(r);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
