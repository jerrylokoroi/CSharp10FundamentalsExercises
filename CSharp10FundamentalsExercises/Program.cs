Console.WriteLine("Enter your character");
string c = Console.ReadLine();

char ascii = char.Parse(c);
Console.WriteLine("\nASCII value of '{0}' is: {1}", c, (int)ascii);