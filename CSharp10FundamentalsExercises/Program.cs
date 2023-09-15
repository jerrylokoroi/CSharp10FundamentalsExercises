string filePath = @"C:\Users\Renter\Development\CSharp10FundamentalsExercises\CSharp10FundamentalsExercises\output.txt";

using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("Hello, World!");
}

string content = File.ReadAllText(filePath);

if (content == "Hello, World!")
{
    Console.WriteLine("Text was successfully written to the file.");
}
else
{
    Console.WriteLine("Error: Text was not written to the file.");
}
