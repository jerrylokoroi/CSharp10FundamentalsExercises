Random random = new Random();
int targetNumber = random.Next(1, 101);
int guess;

Console.WriteLine("Guess the number between 1 and 100!");

do
{
    Console.Write("Enter your guess: ");
    guess = int.Parse(Console.ReadLine());

    if (guess == targetNumber)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
    }
    else if (guess < targetNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else
    {
        Console.WriteLine("Too high! Try again.");
    }
} while (guess != targetNumber);