using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFH
{
    public class Person
    {
        public Person(int id, string name, string firstName, DateTime birthDate)
        {
            this.Id = id;
            this.Name = name;
            this.FirstName = firstName;
            this.BirthDate = birthDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] {1} {2} {3}", Id, Name, FirstName, BirthDate); 
        }

        public static Person[] GetPersons()
        {
            return new Person[]
            {
                new Person ( 7, "Muster", "Hans", new DateTime(1972, 12, 01)),
                new Person ( 4, "Meyer", "Hansueli", new DateTime(1955, 1, 2)),
                new Person ( 8, "Abacus", "Housi", new DateTime(1968, 7, 3)),
                new Person ( 1, "Zbinden", "Zita", new DateTime(1983, 9, 21)),
                new Person ( 3, "Habakuk", "Schorsch", new DateTime(1971, 11, 11)),
                new Person ( 5, "Black", "John", new DateTime(1981, 12, 11)),
                new Person ( 6, "Black", "Sally", new DateTime(1985, 5, 23)),
                new Person ( 7, "White", "John", new DateTime(1988, 4, 3)),
                new Person ( 8, "White", "Sally", new DateTime(1989, 4, 14)),
                new Person ( 9, "Habakuk", "Hans", new DateTime(1983, 9, 21))
            };
        }
    }
}
