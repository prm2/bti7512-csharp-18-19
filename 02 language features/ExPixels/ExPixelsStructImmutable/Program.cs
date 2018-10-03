using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    class Program
    {
        static Pixel[,] RandomImage(int width, int height)
        {
            Random random = new Random();
            Pixel[,] img = new Pixel[width,height];
            for (int w = 0; w < width; w++)
            {
                for (var h = 0; h < height; h++)
                {
                    var p = new Pixel(
                    (byte)random.Next(255),
                    (byte)random.Next(255),
                    (byte)random.Next(255));
                    img[w,h] = p;
                }
            }
            return img;
        }

        static void ToGray(Pixel[,] img)
        {
            var width = img.GetLength(0);
            var height = img.GetLength(1);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    img[i,j] = img[i,j].ToGray();
        }

        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();

            time.Start();

            Pixel[,] img = RandomImage(5184, 3456);

            TimeSpan ts = time.Elapsed;
            Console.WriteLine($"Image created; time elapsed {ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds:00}");

            ToGray(img);

            time.Stop();
            ts = time.Elapsed;
            Console.WriteLine(img[10,10]);
            Console.WriteLine($"Gray scale completed; time elapsed {ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds:00}");

            Console.ReadLine();
        }
    }
}
