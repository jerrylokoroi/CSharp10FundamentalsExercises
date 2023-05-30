static void Main()
{
    Console.WriteLine("Welcome to the Sport Application!");
    Console.WriteLine("Please enter the number of hours of exercise per week:");

    int hoursOfExercise = Convert.ToInt32(Console.ReadLine());

    string fitnessLevel = CalculateFitnessLevel(hoursOfExercise);
    bool hasBonus = CheckBonus(hoursOfExercise);

    Console.WriteLine("Your fitness level is: " + fitnessLevel);

    if (hasBonus)
    {
        Console.WriteLine("Congratulations! You have earned an extra bonus!");
    }

    Console.WriteLine("Thank you for using the Sport Application. Keep exercising!");

    // Wait for user input to exit the application
    Console.ReadLine();
}

static string CalculateFitnessLevel(int hoursOfExercise)
{
    if (hoursOfExercise < 3)
    {
        return "Beginner";
    }
    else if (hoursOfExercise < 6)
    {
        return "Intermediate";
    }
    else if (hoursOfExercise < 10)
    {
        return "Advanced";
    }
    else
    {
        return "Expert";
    }
}

static bool CheckBonus(int hoursOfExercise)
{
    return hoursOfExercise > 10;
}