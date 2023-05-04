Console.WriteLine("Enter your character");
string c = Console.ReadLine();

char ascii = char.Parse(c);
Console.WriteLine($"\nASCII value of '{c}' is: {(int)ascii}");