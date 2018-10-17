using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CastAndOfType
{
    public class Person
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }
    }

    public class Student : Person
    {
        public char Division
        {
            get;
            set;
        }

        public string Class
        {
            get;
            set;
        }
    }

    public class PersonCollection : List<Person>
    {
        public static PersonCollection GetData()
        {
            return new PersonCollection
            {
                new Person { FirstName = "Peter", LastName = "Black" },
                new Student { FirstName = "Sally", LastName = "White", Division = 'I', Class = "I2r" },
                new Person { FirstName = "Paul", LastName = "Brown" },
                new Student { FirstName = "Sandy", LastName = "Miller", Division = 'V', Class = "V2a" },
                new Student { FirstName = "Chris", LastName = "Meier", Division = 'I', Class = "I2a" }, 
                new Person { FirstName = "Jim", LastName = "Knopf" },
                new Student { FirstName = "Johnny", LastName = "B. Good", Division = 'I', Class = "I1b" }
            };
        }
    }
}
