using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Triangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine($"Drawing a triangle shape.");
        }
    }
}
