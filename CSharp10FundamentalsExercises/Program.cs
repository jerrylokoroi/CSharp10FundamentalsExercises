using CSharp10FundamentalsExercises;
using CSharp10FundamentalsExercises.MyShapes;

// Creating instances of each shape
CSharp10FundamentalsExercises.Circle circle = new CSharp10FundamentalsExercises.Circle(5);
Square square = new Square(4);
CSharp10FundamentalsExercises.Rectangle rectangle = new CSharp10FundamentalsExercises.Rectangle(3, 6);

// Calculating and printing the areas
Console.WriteLine("Circle area: " + circle.CalculateArea());
Console.WriteLine("Square area: " + square.CalculateArea());
Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());




