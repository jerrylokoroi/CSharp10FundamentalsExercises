static void Main()
{
    const int NumberOfAges = 3;  // Change this value to adjust the number of ages to read

    // Read age values from the user
    int[] ages = ReadAges(NumberOfAges);

    // Calculate the average age
    double averageAge = CalculateAverageAge(ages);

    // Print the result in a nice format
    PrintAverageAge(averageAge);

    Console.ReadLine();  // Wait for the user to press Enter
}

static int[] ReadAges(int numberOfAges)
{
    int[] ages = new int[numberOfAges];

    for (int i = 0; i < numberOfAges; i++)
    {
        Console.Write($"Enter age {i + 1}: ");
        ages[i] = Convert.ToInt32(Console.ReadLine());
    }

    return ages;
}

static double CalculateAverageAge(int[] ages)
{
    int sum = 0;
    for (int i = 0; i < ages.Length; i++)
    {
        sum += ages[i];
    }

    double averageAge = (double)sum / ages.Length;
    return averageAge;
}

static void PrintAverageAge(double averageAge)
{
    Console.WriteLine($"Average age: {averageAge:F2}");
}