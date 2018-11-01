using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGrouping
{
    class Program
    {
        static void GroupedAlpha()
        {
            using (var data = new X2a2015Entities())
            {
                //data.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var res = data.People
                    .OrderBy(p => p.Name).ThenBy(p => p.Firstname)
                    .GroupBy(p => p.Name.Substring(0, 1), 
                             p => p, 
                             (key, people) => new { Key = key, People = people });
                foreach (var r in res)
                {
                    Console.WriteLine(r.Key);
                    Console.ReadLine();
                    foreach (var p in r.People)
                        Console.WriteLine("\t{0} {1}", p.Name, p.Firstname);
                }
            }
        }

        static void PagedByFirstChar()
        {
            using (var data = new X2a2015Entities())
            {
                //data.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var ch = "A";
                while (ch[0] <= 'Z')
                {
                    var res = data.People
                        .OrderBy(p => p.Name).ThenBy(p => p.Firstname)
                        .AsEnumerable()
                        .SkipWhile(p => p.Name.Substring(0,1) != ch).TakeWhile(p => p.Name.Substring(0,1) == ch).ToList();
                    Console.WriteLine(ch);
                    Console.ReadLine();
                    foreach (var p in res)
                        Console.WriteLine("\t{0} {1}", p.Name, p.Firstname);
                    ch = ((char)(ch[0] + 1)).ToString();
                }
            }
        }

        static void PagedByFirstChar2()
        {
            using (var data = new X2a2015Entities())
            {
                //data.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var ch = "A";
                while (ch[0] <= 'Z')
                {
                    var res = data.People
                        .Where(p => p.Name.Substring(0, 1) == ch)
                        .OrderBy(p => p.Name).ThenBy(p => p.Firstname);
                    Console.WriteLine(ch);
                    Console.ReadLine();
                    foreach (var p in res)
                        Console.WriteLine("\t{0} {1}", p.Name, p.Firstname);
                    ch = ((char)(ch[0] + 1)).ToString();
                }
            }
        }

        const int PAGE_SIZE = 100;

        static void PagedByCount()
        {
            using (var data = new X2a2015Entities())
            {
                //data.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var first = 0;
                var len = 1;
                while (len > 0)
                {
                    var res = data.People
                        .OrderBy(p => p.Name).ThenBy(p => p.Firstname)
                        .Skip(first).Take(PAGE_SIZE).ToList();
                    len = res.Count;
                    if (len > 0)
                    {
                        Console.Write(first);
                        first = first + len;
                        Console.WriteLine(" - {0}", first - 1);
                        Console.ReadLine();
                        foreach (var p in res)
                            Console.WriteLine("\t{0} {1}", p.Name, p.Firstname);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            GroupedAlpha();
            //PagedByFirstChar();
            //PagedByFirstChar2();
            //PagedByCount();

            Console.ReadLine();
        }
    }
}
