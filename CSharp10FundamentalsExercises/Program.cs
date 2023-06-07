using CSharp10FundamentalsExercises;

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter the activiy:");
string activity = Console.ReadLine();
Console.WriteLine("Enter the number of average hours of workout per day:");
string averageHoursPerDay = Console.ReadLine();

int totalAverageHoursPerWeek = Utility.CalcTotalNumOfHrsOfWorkoutPerWeek(averageHoursPerDay);
Console.WriteLine($"Congratulations {name} ! You have practiced {activity} for {totalAverageHoursPerWeek} average hours this week. Congatulations!");