using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal struct Rectangle2
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

        }

        public struct Rectangle
        {
            public Point Left { get; set; }
            public Point Right { get; set; }

            public int CalculateArea()
            {
                int width = Math.Abs(Right.X - Left.X);
                int height = Math.Abs(Right.Y - Left.Y);
                return width * height;
            }
        }

    }
}
