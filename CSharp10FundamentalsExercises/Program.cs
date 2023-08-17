using CSharp10FundamentalsExercises;

List<Shape> shapes = new List<Shape> ();

shapes.Add(new Rectangle3());
shapes.Add(new Circle2());

foreach (Shape shape in shapes)
{
    shape.Draw();
}