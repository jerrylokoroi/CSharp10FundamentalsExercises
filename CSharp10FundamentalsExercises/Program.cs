
Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());

string message = (age >= 18 && age <= 24) ? "You are almost eligible to work"
    : (age >= 25 && age <= 70) ? "You are eligible to work"
    : "You are not eligible to work";

Console.WriteLine(message);




