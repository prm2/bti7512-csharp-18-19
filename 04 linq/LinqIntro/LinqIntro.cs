using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BFH.prm1.LinqIntro
{
    class LinqIntro
    {
        static void LinqToObjects()
        {
            Console.WriteLine("\nLinqToObjects\n-----------");

            string[] str = { "Hello World", "Hello .NET", "Hello LINQ" };

           
            var res = from s in str
                      where s.Contains("Hello")
                      orderby s
                      select new{ Upper = s.ToUpper(), Lower = s.ToLower() };

            var res2 = str.Where(s => s.Contains("Hello"))
                .OrderBy(s => s)
                .Select(s => new { Upper = s.ToUpper(), Lower = s.ToLower() });

            foreach (var x in res2)
                Console.WriteLine("{0} {1} {2}", x.Upper, x.Lower, x.GetType().ToString());
        }
        
        static void LinqToXML()
        {
            Console.WriteLine("\nLinqToXML\n---------");

            XElement modules = XElement.Parse(
                @"<modules>
                    <group id=""A"" minCredits=""74"" maxCredits=""82"">
                      <module nb=""2100"" titleDE=""Diskrete Mathematik"" titleFR=""Mathématiques discrètes"" credits=""6""/>
                      <module nb=""2101"" titleDE=""Lineare Algebra"" titleFR=""Algèbre linéaire"" credits=""6"">
                        <dependsOn id=""2100""/>
                      </module>
                    </group>
                    <group id=""D1"" minCredits=""10"" maxCredits=""26"">
                      <module nb=""7511"" titleDE=""DotNet"" titleFR=""DotNet"" credits=""2""/>
                    </group>
                  </modules>");

            var res = from m in modules.Elements("group").Elements("module")
                      where m.Attribute("credits").Value == "6"
                      select m.Attribute("titleFR").Value;

            foreach (var s in res)
                Console.WriteLine(s + "  " + s.GetType().ToString());
        }

        static void TypeConversion()
        {
            Console.WriteLine("\nTypeConversion\n--------------");

            string[] str = { "1", "99", "17", "28", "93" };
            int sum = 0;

            foreach (int i in str.Select((s) => Int32.Parse(s)))
            {
                sum += i;
                Console.WriteLine("i={0}\tsum={1}", i, sum);
            }

            Console.WriteLine("SUM = {0} ", str.Select((s) => Int32.Parse(s)).Sum());
        }

        static void LinqToEntities()
        {
            var db = new X2a2015Entities();


            var res = from p in db.Person
                      where p.Firstname == "Peter"
                      orderby p.Name
                      select p;

            var res2 = db.Person
                .Where(p => p.Firstname == "Peter")
                .OrderBy(p => p.Name)
                .Select(p => p);

            foreach (var p in res2)
                Console.WriteLine("{0} {1} {2}", p.Name, p.Firstname, p.Birthdate);


        }

        static void Main(string[] args)
        {
            //LinqToObjects();
            //LinqToXML();
            //TypeConversion();
            LinqToEntities();

            Console.ReadLine();
        }
    }
}
