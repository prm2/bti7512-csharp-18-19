using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Yielding
{
    class Yielding
    {
        static int lineNb = 0;
        static IEnumerable<string> DynamicStrings()
        {
            yield return "BEGIN";
            yield return $"  Time is {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";

            for (int i = 0; i < 5; i++)
                yield return $"  Line {lineNb++}; next will be {lineNb}";
            yield return $"  Line {lineNb}; no more will follow!";

            yield return "END";
        }

        static IEnumerable<int> Even(int[] numbers)
        {
            Console.WriteLine("starting Even method");
            foreach (var i in numbers)
                if (i % 2 == 0)
                    yield return i;
            Console.WriteLine("ending Even method");
        }

        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 8, 11, 17, 24, 36, 48, 49, 50, 60, 80, 101 };

            Console.WriteLine("Even numbers: ");

            var even = Even(numbers);

            foreach (var i in even)
                Console.WriteLine(i);

            Console.WriteLine("\nA dynamically created list of strings");

            var strings = DynamicStrings();

            foreach (var s in strings)
                Console.WriteLine(s);

            Console.WriteLine("\ndone.");
            Console.ReadLine();
        }
    }
}
