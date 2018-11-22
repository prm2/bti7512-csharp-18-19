using BFH.WebSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSearchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Searcher.Status = (s) => { Console.WriteLine(s); };

            var res = Searcher.FindWordAsync("BFH").Result;

            foreach (var r in res)
                Console.WriteLine("{0} \t{1}", r.Count, r.Url);

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
