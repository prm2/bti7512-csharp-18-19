using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodVirtualization
{
    class Alpha
    {
        public int I { get; set; }
        public Alpha(int i)
        {
            this.I = i;
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine($"Alpha.VirtualMethod I={I}");
        }

        public void NonVirtualMethod()
        {
            Console.WriteLine($"Alpha.NonVirtualMethod I={I}");
        }

    }

    class Beta : Alpha
    {
        public Beta(int i) : base(i)
        {
        }

        public override void VirtualMethod()
        {
            Console.WriteLine($"Beta.VirtualMethod I={I}");
        }

        public new void NonVirtualMethod()
        {
            Console.WriteLine($"Beta.NonVirtualMethod I={I}");
        }
    }

    class Gamma : Beta
    {
        public Gamma(int i) : base(i)
        {
        }

        public override void VirtualMethod()
        {
            Console.WriteLine($"Gamma.VirtualMethod I={I}");
        }

        public new void NonVirtualMethod()
        {
            Console.WriteLine($"Gamma.NonVirtualMethod I={I}");
        }
    }

    class MethodVirtualization
    {
        static void Main(string[] args)
        {
            Alpha alpha = new Alpha(1);
            Beta beta = new Beta(2);
            Gamma gamma = new Gamma(3);

            alpha.VirtualMethod();
            alpha.NonVirtualMethod();
            beta.VirtualMethod();
            beta.NonVirtualMethod();
            gamma.VirtualMethod();
            gamma.NonVirtualMethod();

            Console.WriteLine("-------------------");
            alpha = new Beta(4);
            beta = new Gamma(5);

            alpha.VirtualMethod();
            alpha.NonVirtualMethod();
            beta.VirtualMethod();
            beta.NonVirtualMethod();

            Console.WriteLine("-------------------");
            alpha = new Gamma(6);

            alpha.VirtualMethod();
            alpha.NonVirtualMethod();

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
