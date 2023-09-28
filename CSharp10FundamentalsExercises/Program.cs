try
{
    string filePath = @"C:\Users\Renter\Development\CSharp10FundamentalsExercises\CSharp10FundamentalsExercises\File_path\sample.txt";

    if (File.Exists(filePath))
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine("File Content:");
        Console.WriteLine(content);
    }
    else
    {
        Console.WriteLine("Error: The specified file does not exist.");
    }
}
/*catch (FileNotFoundException ex)
{
    Console.WriteLine("Error: File not found. " + ex.Message);
}*/
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
