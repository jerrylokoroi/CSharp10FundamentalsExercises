// Prompt user for file path
Console.Write("Enter the file path: ");
string filePath = Console.ReadLine();

// Check if the file exists
if (File.Exists(filePath))
{
    // Read the file using FileStream and StreamReader
    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
    {
        using (StreamReader reader = new StreamReader(fs))
        {
            string line;

            // Read and print each line
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
else
{
    Console.WriteLine("File not found.");
}