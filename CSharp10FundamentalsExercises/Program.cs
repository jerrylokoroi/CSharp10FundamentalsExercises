Console.WriteLine("Enter first name: ");
string firstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
string lastName = Console.ReadLine();


Console.WriteLine($"Hello \n{firstName.Trim().ToUpper()} {lastName.Trim().ToUpper()}");