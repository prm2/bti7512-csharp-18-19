using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Serial
{
    class Serial
    {
        static Random rand = new Random();

        static int BookPlane()
        {
            Console.WriteLine("Booking plane ...");
            Console.WriteLine(" thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Done with plane booking ...");
            return rand.Next(1000);
        }

        static int BookHotel()
        {
            Console.WriteLine("Booking hotel ...");
            Console.WriteLine(" thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(8000);
            Console.WriteLine("Done with hotel booking ...");
            return 1000 + rand.Next(1000);
        }

        static int BookCar()
        {
            Console.WriteLine("Booking car ...");
            Console.WriteLine(" thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Done with car booking ...");
            return 2000 + rand.Next(1000);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Stopwatch sw = Stopwatch.StartNew();

            int carId = BookCar();
            int hotelId = BookHotel();
            int planeId = BookPlane();

            Console.WriteLine("Done in {0} secs.", sw.ElapsedMilliseconds / 1000.0);
            Console.ReadLine();
        }
    }
}
