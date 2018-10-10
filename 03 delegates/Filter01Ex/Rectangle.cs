using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFH
{
    public struct Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return String.Format("[w={0}, h={1}] ", Width, Height);
        }

        public static List<Rectangle> GetRectangles()
        {
            return new List<Rectangle>
            {
                new Rectangle { Width = 20.0, Height = 17.5 },
                new Rectangle { Width = 2.0, Height = 1.5 },
                new Rectangle { Width = 4.0, Height = 11.0 },
                new Rectangle { Width = 20, Height = 22 },
                new Rectangle { Width = 4.0, Height = 12.0 },
                new Rectangle { Width = 20, Height = 11 },
                new Rectangle { Width = 44, Height = 55 },
                new Rectangle { Width = 22.22, Height = 33.33 }
            };
        }
    }


}
