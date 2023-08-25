Console.Write("Enter a number: ");
string userInput = Console.ReadLine();

int parsedValue = int.Parse(userInput);  // Set breakpoint here

int result = parsedValue * 2;

Console.WriteLine($"The result of doubling the parsed value {parsedValue} is {result}");