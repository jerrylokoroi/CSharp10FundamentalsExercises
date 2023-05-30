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

    switch (operation)
    {
        case 1:
            Add(num1, num2);
            break;
        case 2:
            Subtract(num1, num2);
            break;
        case 3:
            Multiply(num1, num2);
            break;
        case 4:
            Divide(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid operation!");
            break;
    }
}

static void Add(decimal a, decimal b)
{
    decimal result = a + b;
    Console.WriteLine("The sum is: " + result);
}

static void Subtract(decimal a, decimal b)
{
    decimal result = a - b;
    Console.WriteLine("The difference is: " + result);
}

static void Multiply(decimal a, decimal b)
{
    decimal result = a * b;
    Console.WriteLine("The product is: " + result);
}

static void Divide(decimal a, decimal b)
{
    if (b != 0)
    {
        decimal result = a / b;
        Console.WriteLine("The quotient is: " + result);
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed!");
    }
}