using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    public class Car
    {
        // Fields
            private string modelName;
            private string color;
            private int maxSpeed;

            // Constructor
            public Car(string modelName, string color, int maxSpeed)
            {
                this.color = color;
                this.maxSpeed = maxSpeed;
                this.modelName = modelName;  
            }

        // Method
        public void StartEngine()
            {
               Console.WriteLine("Engine started!");
            }
        
    }
}