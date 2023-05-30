Func<decimal, decimal, decimal> Add = (a, b) => a + b;
Func<decimal, decimal, decimal> Subtract = (a, b) => a - b;
Func<decimal, decimal, decimal> Multiply = (a, b) => a * b;
Func<decimal, decimal, decimal> Divide = (a, b) => b != 0 ? a / b : 0;

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
