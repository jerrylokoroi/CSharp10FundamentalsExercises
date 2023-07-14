string name = GetNameFromUser();
Console.WriteLine("Hello, " + name + "! Welcome to the program.");

static string GetNameFromUser()
{
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Please enter your name.");
        return GetNameFromUser(); // Recursively call the method again
    }

    return name;
}

