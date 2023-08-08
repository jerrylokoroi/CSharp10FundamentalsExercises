List<int> numbers = new List<int> { 5, 8, 10, 15, 20, 25, 30, 35 };

List<int> filteredNumbers = GetEvenNumbersGreaterThanEqualTo10(numbers);

Console.WriteLine("Filtered numbers:");
foreach (int number in filteredNumbers)
{
    Console.WriteLine(number);
}

static List<int> GetEvenNumbersGreaterThanEqualTo10(List<int> inputList)
{
    List<int> result = new List<int>();

    foreach (int number in inputList)
    {
        if (number >= 10 && number % 2 == 0)
        {
            result.Add(number);
        }
    }

    return result;
}

