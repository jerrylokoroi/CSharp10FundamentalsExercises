using CSharp10FundamentalsExercises;

List<IDrawable> shapes = new List<IDrawable>();

shapes.Add(new Circle3());
shapes.Add(new Rectangle4());
shapes.Add(new Triangle());

foreach (IDrawable shape in shapes)
{
    shape.Draw();
}