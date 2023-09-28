try
{
    Console.Write("Enter a number: ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    int result = DivideByTen(userInput);
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Invalid input. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
    

    static int DivideByTen(int number)
{
    if (number == 0)
    {
        throw new DivideByZeroException();
    }

    return 10 / number;
}
