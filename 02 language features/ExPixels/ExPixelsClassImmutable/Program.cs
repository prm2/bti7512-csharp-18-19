using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

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

        static Pixel[,] ImageFromFile()
        {
            var bmp = new Bitmap("C:\\Users\\prm1\\Pictures\\dji\\DJI_0017.JPG");
            var res = new Pixel[bmp.Width, bmp.Height];

            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                    res[i, j] = new Pixel(
                        bmp.GetPixel(i, j).R, 
                        bmp.GetPixel(i, j).G, 
                        bmp.GetPixel(i, j).B);

            return res;
        }

        static void ImageToFile(Pixel[,] bmp)
        {
            var w = bmp.GetLength(0);
            var h = bmp.GetLength(1);
            var img = new Bitmap(w, h);

            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                    img.SetPixel(i, j, Color.FromArgb(
                        bmp[i, j].R, 
                        bmp[i, j].B, 
                        bmp[i, j].B));

            img.Save("C:\\Users\\prm1\\Desktop\\bw-test.jpg", ImageFormat.Jpeg);
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
//            Pixel[,] img = ImageFromFile();

            TimeSpan ts = time.Elapsed;
            Console.WriteLine($"Image created; time elapsed {ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds:00}");

            ToGray(img);

            time.Stop();
            ts = time.Elapsed;
            Console.WriteLine(img[10,10]);
            Console.WriteLine($"Gray scale completed; time elapsed {ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds:00}");

            ImageToFile(img);

            Console.ReadLine();
        }
    }
}
