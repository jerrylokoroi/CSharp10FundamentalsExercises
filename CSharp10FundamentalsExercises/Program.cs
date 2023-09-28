try
{
    Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();

    double number = Convert.ToDouble(userInput);

    Console.WriteLine($"You entered the number: {number}");
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Input is not a valid number. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
