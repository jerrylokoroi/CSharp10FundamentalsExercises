using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Car2
    {
        private Engine engine;

        public Car2()
        {
            engine = new Engine();
        }
        public void StartEngine()
        {
            engine.Start();
        }
    }
}
