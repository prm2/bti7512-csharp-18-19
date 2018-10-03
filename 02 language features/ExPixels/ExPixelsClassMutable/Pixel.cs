using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    public class Pixel
    {
        public Pixel(byte v)
        {
            R = v; G = v; B = v;
        }
        public Pixel(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }

        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public override string ToString()
        {
            return $"({R},{G},{B})";
        }

        public void ToGray()
        {
            byte gray = (byte)(0.299 * R + 0.587 * G + 0.114 * B);
            R = gray;
            B = gray;
            G = gray;
        }
    }
}
