Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int factorial = CalculateFactorial(number);

Console.WriteLine($"The factorial of {number} is {factorial}");

static int CalculateFactorial(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        return n * CalculateFactorial(n - 1);
    }
}