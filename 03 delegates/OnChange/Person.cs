using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnChange
{
    public delegate void NameChangedDelegate(Person person);

    public class Person
    {
        string name;

        public NameChangedDelegate NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    if (NameChanged != null)
                        NameChanged(this);
                }
            }
        }


    }
}
