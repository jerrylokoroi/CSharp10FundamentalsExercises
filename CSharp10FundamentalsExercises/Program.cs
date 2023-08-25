Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is even.");  // This is the bug! // To fix Bug Console.WriteLine("The number is odd.")
}