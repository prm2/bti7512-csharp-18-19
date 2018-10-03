using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.BFH.CSharpIntro
{
    public struct Pixel
    {
        public Pixel(byte v)
        {
            R = v; G = v; B = v;
        }
        public Pixel(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }

        public byte R { get; }
        public byte G { get; }
        public byte B { get; }

        public override string ToString()
        {
            return $"({R},{G},{B})";
        }

        public Pixel ToGray()
        {
            return new Pixel((byte)(0.299 * R + 0.587 * G + 0.114 * B));
        }
    }
}
