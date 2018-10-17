using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CastAndOfType
{
    class Program
    {
        static void SelectAll()
        {
            Console.WriteLine("\nall persons:");
            Console.WriteLine(  "------------");
            foreach (var p in PersonCollection.GetData())
            {
                if (p is Person)
                    Console.Write("{0}\t{1}", p.FirstName, p.LastName);
                if (p is Student)
                    Console.Write("\t{0}\t{1}", ((Student)p).Division, ((Student)p).Class);
                Console.WriteLine();
            }
        }

        static void SelectStudentsWithCast()
        {
            Console.WriteLine("\nstudents (filtered with 'Cast'):");
            Console.WriteLine(  "--------------------------------");
            // TODO
        }

        static void SelectStudentsWithOfType()
        {
            Console.WriteLine("\nstudents (filtered with 'OfType'):");
            Console.WriteLine(  "----------------------------------");
            // TODO
        }

        static void Main(string[] args)
        {
            SelectAll();
            SelectStudentsWithCast();
            SelectStudentsWithOfType();

            Console.ReadLine();
        }
    }
}
