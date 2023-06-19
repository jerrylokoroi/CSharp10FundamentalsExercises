using CSharp10FundamentalsExercises;

Employee employee = new("Jerry", 23, 30000);
Console.WriteLine($"Initial Salary: {employee.Salary}");

employee.GiveRaise(10000);
Console.WriteLine($"New Salary after Raise: {employee.Salary}");
