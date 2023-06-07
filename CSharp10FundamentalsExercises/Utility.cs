using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Utility
    {

        public static int CalcTotalNumOfHrsOfWorkoutPerWeek(string averageHoursPerDay)
        {
            int averageHoursPerWeek =  int.Parse(averageHoursPerDay) * 7;
            return averageHoursPerWeek;
        }
        static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber + secondNumber;
            return result;
        }

        static decimal Add(string firstString, string secondString)
        {
            decimal firstNumber;
            decimal secondNumber;

            if (decimal.TryParse(firstString, out firstNumber) && decimal.TryParse(secondString, out secondNumber))
            {
                return Add(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Error: Invalid input for addition!");
                return 0; // Return 0 as a default value when input is invalid
            }
        }

        static decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber - secondNumber;
            return result;
        }

        static decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber * secondNumber;
            return result;
        }

        static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            if (secondNumber != 0)
            {
                decimal result = firstNumber / secondNumber;
                return result;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed!");
                return 0; // Return 0 as a default value when division by zero occurs
            }
        }
    }
}
