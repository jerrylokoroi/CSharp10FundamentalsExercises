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

    decimal result = 0;

    switch (operation)
    {
        case 1:
            result = Add(num1, num2);
            break;
        case 2:
            result = Subtract(num1, num2);
            break;
        case 3:
            result = Multiply(num1, num2);
            break;
        case 4:
            result = Divide(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid operation!");
            break;
    }

    Console.WriteLine("The result is: " + result);
}

static decimal Add(decimal a, decimal b)
{
    decimal result = a + b;
    return result;
}

static decimal Subtract(decimal a, decimal b)
{
    decimal result = a - b;
    return result;
}

static decimal Multiply(decimal a, decimal b)
{
    decimal result = a * b;
    return result;
}

static decimal Divide(decimal a, decimal b)
{
    if (b != 0)
    {
        decimal result = a / b;
        return result;
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed!");
        return 0; // Return 0 as a default value when division by zero occurs
    }
}

Main();