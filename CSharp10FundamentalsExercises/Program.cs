Console.WriteLine("Enter first name: ");
string firstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
string lastName = Console.ReadLine();

Console.WriteLine("Enter city: ");
string city = Console.ReadLine();

Console.WriteLine("Enter street: ");
string street = Console.ReadLine();

Console.WriteLine("Enter PO box: ");
int address = int.Parse(Console.ReadLine());

Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}\nCity: {city}\nStreet: {street}\nP.O. Box: {address}\n");