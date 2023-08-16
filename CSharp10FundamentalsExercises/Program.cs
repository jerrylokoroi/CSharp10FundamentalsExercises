using CSharp10FundamentalsExercises;

Mammals dog = new Mammals
{
    Name = "Dog",
    Weight = 15.5,
    NumberOfLegs = 4
};

dog.Eat();
dog.Sleep();
dog.Move();

Console.WriteLine($"{dog.Name} weighs {dog.Weight} pounds and has {dog.NumberOfLegs} legs.");
