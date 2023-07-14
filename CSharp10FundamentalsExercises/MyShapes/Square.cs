using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises.MyShapes
{
    internal class Square
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }
        public double CalculateArea() { 
            return Math.Pow(sideLength, 2);
        } 

    }
}
