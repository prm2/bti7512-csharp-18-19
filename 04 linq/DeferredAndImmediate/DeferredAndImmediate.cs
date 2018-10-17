using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeferredAndImmediate
{
    class DeferredAndImmediate
    {
        static int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        static void Deferred()
        {
            Console.WriteLine("Deferred execution");

            int i = 0;
            var res =
                from n in numbers
                select new { N = n, I = i++ };

            foreach (var r in res)
                Console.WriteLine($"N = {r.N} I = {r.I} i = {i}");

            Console.WriteLine();
        }

        static void Immediate()
        {
            Console.WriteLine("Immediate execution");

            int i = 0;
            var res = (
                from n in numbers
                select new { N = n, I = i++ })
                .ToList();

            foreach (var r in res)
                Console.WriteLine($"N = {r.N} I = {r.I} i = {i}");

            Console.WriteLine();
        }

        static void ResultReuse()
        {
            Console.WriteLine("Result reuse");

            var lowNumbers =
                    (from n in numbers
                    where n <= 3
                    select n).ToList();

            Console.WriteLine("First run numbers <= 3:");
            foreach (int n in lowNumbers)
                Console.WriteLine(n);

            Console.WriteLine();

            var n2 = lowNumbers;

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = -numbers[i];

            Console.WriteLine("Second run numbers <= 3:");
            foreach (int n in lowNumbers)
                Console.WriteLine(n);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Deferred();
            Immediate();
            ResultReuse();

            Console.ReadLine();
        }
    }
}
