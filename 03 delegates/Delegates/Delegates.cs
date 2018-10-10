using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace BFH
{
    public delegate void Notifier(string x);

    public delegate int IntProc(int i);

    public class Delegates
    {

        static void FirstMethod(string name)
        {
            Console.WriteLine("FirstMethod({0})", name);
        }

        static void SecondMethod(string name)
        {
            Console.WriteLine("SecondMethod({0})", name);
        }

        class InnerClass
        {
            public Notifier Notify = null;

            public void SomeWork()
            {
                // some work

                if (Notify != null)
                    Notify("from inner class");
            }
        }

        class AnotherClass
        {
            string text;
            public Notifier LocalTextChanged;

            public string LocalText
            {
                get { return text; }
                set
                {
                    text = value;
                    if (LocalTextChanged != null)
                        LocalTextChanged(value);
                }
            }

            public void MyMethod(string s)
            {
                Console.WriteLine("MyMethod({0}) Local Text is '{1}'", s, LocalText);
            }
        }

        public static void Test()
        {
            Notifier n = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Delegates.Test();
            Console.ReadLine();
        }
    }
}

