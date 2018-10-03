using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    // This class has no explicit base class. It implicitly
    // inherits from System.Object.
    public class Pet
    {
        public Pet(string name)
        {
            Console.WriteLine("Pet({0})", (name== null) ? "null" : name);
        } 

        // This constructor calls another constructor in the same
        // with one parameter value set to null.
        public Pet()
            : this(null)
        {
            Console.WriteLine("Pet()");
        }
    }

    // This class explicitly inherits from the class Pet.
    public class Mammal : Pet
    {
        // This constructor explicitly calls the constructor of the
        // base class having one string parameter.
        public Mammal(string name)
            : base(name)
        {
            Console.WriteLine("Mammal({0})", (name == null) ? "null" : name);
        }

        // This constructor implicitly calls the parameterless
        // constructor of the base class.
        public Mammal()
        {
            Console.WriteLine("Mammal()");
        }
    }

    public class Dog : Mammal
    {
        // This constructor implicitly calls the parameterless
        // constructor of the base class.
        public Dog(string name)
        {
            Console.WriteLine("Dog({0})", (name == null) ? "null" : name);
        }
    }

    // A partial class means that there could be another part of the same
    // class somewhere in another code file.
    public partial class Cat : Mammal
    {
        public Cat(string name)
            : base(name)
        {
            Console.WriteLine("Cat({0})", (name == null) ? "null" : name);
        }

        //partial void PartialMethod()
        //{
        //    Console.WriteLine("Cat.PartialMethod() (in part 1)");
        //}

        // This is a nested class. It is used without an instance of the
        // hosting class Cat.
        public class Helper
        {
            public Helper()
            {
                Console.WriteLine("Cat.Helper.Helper()");
            }

            public void Help()
            {
                Console.WriteLine("Cat.Helper.Help()");
            }
        }
    }

    public class Fish : Pet
    {
        // This class has not explicit constructor. It has an
        // implicit and parameterless constructor which calls
        // the parameterless constructor of the base class.
    }

    // This class is abstract, i.e. it may not be instantiated
    // but subclassed.
    public abstract class Reptile : Pet
    {
        // No need for this constructor to be public.
        protected Reptile()
            : base()
        {
            Console.WriteLine("Reptile()");
        }
    }

    // This class is sealed, i.e. it may not be subclassed but
    // instantiated.
    public sealed class Snake : Reptile
    {
        // This constructor implicitly calls the protected constructor
        // of the base class
        public Snake()
        {
            Console.WriteLine("Snake()");
        }
    }

    // A static class has only static members. It may not be instantiated
    // nor subclassed. Static classes always derive from System.Object.
    public static class PetHelper
    {
        // A static constructor is called implicitly when the class is used
        // for the first time.
        static PetHelper()
        {
            Console.WriteLine("PetHelper()");
        }

        public static void Help()
        {
            Console.WriteLine("PetHelper.Help()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet fido = new Dog("Fido");
            Fish fish = new Fish();

            //Pet r = new Reptile();

            PetHelper.Help();

            Cat.Helper catHelper = new Cat.Helper();
            catHelper.Help();

            Cat micky = new Cat("Micky");
            micky.Meow();

            Object b = new BaseClass();
            Object d = new DerivedClass();
            Console.WriteLine("b:\n{0} \n d:\n{1}", b, d);

            Console.ReadLine();
        }
    }
}
