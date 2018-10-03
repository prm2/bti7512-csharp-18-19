using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    // Another part of the class Cat. It does not have an explicit
    // declaration of a base class. The whole class Cat derives
    // from class Mammal as declared in the other part.
    public partial class Cat
    {
        public void Meow()
        {
            Console.WriteLine("meow, meow, meow");

            Console.WriteLine("calling PartialMethod() (in part 2)");
            PartialMethod();
        }

        // A partial method means that another part of the class
        // may or may not implement the method.
        partial void PartialMethod();
    }
}
