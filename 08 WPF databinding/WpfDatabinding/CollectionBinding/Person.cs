using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionBinding
{
    public class PersonList : ObservableCollection<Person>
    { }

    public class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
    }
}
