using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Utility
    {

        static Random random = new Random();

        public static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string modifiedString = InsertRandomCharacters(input);
            Console.WriteLine("Modified string:");
            Console.WriteLine(modifiedString);

            InsertRandomCharacters(input);
        }

        static string InsertRandomCharacters(string input)
        {
            string modifiedString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                modifiedString += input[i];

                if (random.NextDouble() < 0.2)
                {
                    // Insert '\n' with 20% probability
                    modifiedString += '\n';
                }

                if (random.NextDouble() < 0.1)
                {
                    // Insert '\t' with 10% probability
                    modifiedString += '\t';
                }
            }
          
            return modifiedString;

        }
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
