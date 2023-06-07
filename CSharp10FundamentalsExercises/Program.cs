Console.WriteLine("Enter a decimal value:");
decimal input = Decimal.Parse(Console.ReadLine());

string formattedValue = input.ToString("0.00");
Console.WriteLine("Formatted value: " + formattedValue);