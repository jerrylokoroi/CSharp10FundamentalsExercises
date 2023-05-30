static void Main()
{
    Console.WriteLine("Welcome to the Calculator!");

    Console.WriteLine("Enter the first number:");
    decimal num1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    decimal num2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("Enter the operation number:");

    int operation = int.Parse(Console.ReadLine());

    decimal result = operation switch
    {
        1 => num1 + num2,
        2 => num1 - num2,
        3 => num1 * num2,
        4 => num1 / num2,
        _ => throw new InvalidOperationException("Invalid operation!")
    };

    Console.WriteLine("The result is: " + result);
}


Main();