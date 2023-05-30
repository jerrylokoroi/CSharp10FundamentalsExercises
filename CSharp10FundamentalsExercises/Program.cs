static void Main()
{
    Console.WriteLine("Welcome to the Calculator!");

    Console.WriteLine("Enter the first value:");
    string input1 = Console.ReadLine();

    Console.WriteLine("Enter the second value:");
    string input2 = Console.ReadLine();

    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("Enter the operation number:");

    int operation = int.Parse(Console.ReadLine());

    decimal result = 0;

    switch (operation)
    {
        case 1:
            result = Add(input1, input2);
            break;
        case 2:
            result = Subtract(decimal.Parse(input1), decimal.Parse(input2));
            break;
        case 3:
            result = Multiply(decimal.Parse(input1), decimal.Parse(input2));
            break;
        case 4:
            result = Divide(decimal.Parse(input1), decimal.Parse(input2));
            break;
        default:
            Console.WriteLine("Invalid operation!");
            break;
    }

    Console.WriteLine("The result is: " + result);
}

