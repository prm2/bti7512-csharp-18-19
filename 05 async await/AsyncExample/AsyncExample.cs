using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AsyncExample
{
    class AsyncExample
    {
        static Random rand = new Random();

        static int BookPlane()
        {
            Console.WriteLine("Booking plane ...");
            Console.WriteLine("    Plane thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Done with plane booking ...");
            return rand.Next(1000);
        }

        static int BookHotel()
        {
            Console.WriteLine("Booking hotel ...");
            Console.WriteLine("    Hotel thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(8000);
            Console.WriteLine("Done with hotel booking ...");
            return 1000 + rand.Next(1000);
        }

        static int BookCar()
        {
            Console.WriteLine("Booking car ...");
            Console.WriteLine("    Car thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Done with car booking ...");
            return 2000 + rand.Next(1000);
        }

        static async Task<int> BookPlaneAsync()
        {
            int res = await Task.Factory.StartNew<int>(BookPlane);
            return res;
        }

        static async Task<int> BookHotelAsync()
        {
            int res = await Task.Factory.StartNew<int>(BookHotel);
            return res;
        }

        static async Task<int> BookCarAsync()
        {
            int res = await Task.Factory.StartNew<int>(BookCar);
            return res;
        }

        static async Task ExecuteAsync()
        {
            Console.WriteLine("executing");
            var hotelId =  await BookHotelAsync();

            Console.WriteLine("hotelId = " + hotelId);
            var carId   =  BookCarAsync();
            var planeId =  BookPlaneAsync();

            //Console.WriteLine("{0} {1} {2}", await hotelId, await carId, await planeId);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: {0}", Thread.CurrentThread.ManagedThreadId);

            Stopwatch sw = Stopwatch.StartNew();

            var t = ExecuteAsync();
            Console.WriteLine("waiting ...");
            t.Wait();

            Console.WriteLine("Done in {0} secs.", sw.ElapsedMilliseconds / 1000.0);
            Console.ReadLine();
        }
    }
}
