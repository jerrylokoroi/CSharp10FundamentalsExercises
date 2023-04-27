Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("How tall are you?");
double height = double.Parse(Console.ReadLine());

Console.WriteLine("Hi " + name + ", you are " + age + " years old and " + height + " feet tall.");
