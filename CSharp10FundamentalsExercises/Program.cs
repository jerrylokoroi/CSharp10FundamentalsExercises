Random random = new Random();
int targetNumber = random.Next(1, 101);

bool guessedCorrectly = false;

try
{
    while (!guessedCorrectly)
    {
        Console.Write("Guess the number (between 1 and 100): ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        if (userGuess == targetNumber)
        {
            guessedCorrectly = true;
            Console.WriteLine("Congratulations! You guessed the number.");
        }
        else if (userGuess < targetNumber)
        {
            Console.WriteLine("Too low! Try guessing a higher number.");
        }
        else
        {
            Console.WriteLine("Too high! Try guessing a lower number.");
        }
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Invalid input. Please enter a number. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
