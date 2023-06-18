using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Rectangle
    {
        //{ get; } => Defines a property with a read-only accessor
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea(double length, double width)
        {
            double area = Length * Width;
            // return length * width 
            return area;
        }

        public double CalculatePerimeter(double length, double width)
        {
            double perimeter = 2 * (Length + Width);
            // return 2 * (Length + Width)
            return perimeter;
        }
    }
}
