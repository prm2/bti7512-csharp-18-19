using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    public interface IFirst
    {
        void MethodOne();

        void MethodTwo();
    }

    public interface ISecond
    {
        void MethodTwo();

        int Property { get; }
    }

    public class FirstClass : IFirst, ISecond
    {
        public int Property { get; set; }

        public void MethodOne()
        {
            Console.WriteLine("FirstClass.MethodOne()");
        }

        public void MethodTwo()
        {
            Console.WriteLine("FirstClass.MethodTwo() / Property={0}", Property);
        }
    }

    public class SecondClass : IFirst, ISecond
    {
        void IFirst.MethodOne()
        {
            Console.WriteLine("SecondClass.MethodOne()");
        }

        void IFirst.MethodTwo()
        {
            Console.WriteLine("SecondClass.IFirst.MethodTwo() / Property={0}", 
                ((ISecond)this).Property);
        }

        void ISecond.MethodTwo()
        {
            Console.WriteLine("SecondClass.ISecond.MethodTwo() / Property={0}",
                ((ISecond)this).Property);
        }

        int ISecond.Property
        {
            get { return DateTime.Now.Second; }
        }
    }

    class Interfaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("o1");
            FirstClass o1 = new FirstClass();

            o1.Property = 17;
            o1.MethodOne();
            o1.MethodTwo();

            Console.WriteLine("o2");
            SecondClass o2 = new SecondClass();

            ((IFirst)o2).MethodOne();
            ((IFirst)o2).MethodTwo();
            ((ISecond)o2).MethodTwo();

            Console.WriteLine("i1");
            IFirst i1 = new SecondClass();

            i1.MethodOne();
            i1.MethodTwo();

            Console.WriteLine("i2");
            ISecond i2 = new SecondClass();

            i2.MethodTwo();

            Console.ReadLine();
        }
    }
}
