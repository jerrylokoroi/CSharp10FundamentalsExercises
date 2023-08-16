using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Mammals : Animal
    {
        public int NumberOfLegs { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Name} is moving on {NumberOfLegs} legs.");
        }

    }
}
