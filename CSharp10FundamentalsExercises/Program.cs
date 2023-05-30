static void Main(string[] args)
{
    Console.Write("Enter the number of random numbers to generate (default is 10): ");
    string input = Console.ReadLine();
    int count = ParseInput(input);

    int[] randomNumbers = GenerateRandomNumbers(count);

    Console.WriteLine($"Generated {randomNumbers.Length} random numbers:");
    foreach (int number in randomNumbers)
    {
        Console.WriteLine(number);
    }
}

static int ParseInput(string input)
{
    int count = 10; // default value

    if (!string.IsNullOrEmpty(input))
    {
        if (!int.TryParse(input, out count))
        {
            Console.WriteLine("Invalid input. Using default value of 10.");
            count = 10;
        }
    }

    return count;
}

static int[] GenerateRandomNumbers(int count = 10)
{
    Random random = new Random();
    int[] numbers = new int[count];

    for (int i = 0; i < count; i++)
    {
        numbers[i] = random.Next();
    }

    return numbers;
}

