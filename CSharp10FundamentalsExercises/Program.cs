using CSharp10FundamentalsExercises;

// Create a Person object
Person person = new Person("Jerry Lokoroi", 33, "48 Norad ST");

// Get and print the initial values
Console.WriteLine($"Name: {person.GetName()}, Age: {person.GetAge()}, Address: {person.GetAddress()}");

// Set new values
person.SetName("Jerry(Jnr) Feely Ekuwam");
person.SetAge(10);
person.SetAddress("456 Parklands");

// Get and print the updated values
Console.WriteLine($"Name: {person.GetName()}, Age: {person.GetAge()}, Address: {person.GetAddress()}");
