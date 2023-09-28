using CSharp10FundamentalsExercises;

try
{
    Console.Write("Enter a positive number: ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    if (userInput < 0)
    {
        throw new NegativeNumberException("Input is a negative number.");
    }

    double squareRoot = Math.Sqrt(userInput);
    Console.WriteLine($"Square root of {userInput} is: {squareRoot}");
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Invalid input. " + ex.Message);
}
catch (NegativeNumberException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
