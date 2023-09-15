string filePath = @"C:\Users\Renter\Development\CSharp10FundamentalsExercises\CSharp10FundamentalsExercises\output.txt";


// Check if the file exists
if (File.Exists(filePath))
{
    // Read the file using StreamReader
    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;

        // Read and print each line
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
else
{
    Console.WriteLine("File not found.");
}