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
            // Define a subset of numbers
            var intFilter = new GenericFilter<int>();
            var numbers = intFilter.GetSubset(Numbers.GetNumbers(),
                (x) => x > 10, (x) => x < 17);

            Console.WriteLine("filtered numbers:");
            foreach (var n in numbers)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
