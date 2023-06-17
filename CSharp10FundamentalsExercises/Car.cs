using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Car
    {
        private string color;
        private int maxSpeed;

        public void StartEngine()
        {
            Console.WriteLine("Engine Started!");
        }

        public Car (string color, int maxSpeed)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }

       
    }
}
