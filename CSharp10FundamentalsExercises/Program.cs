// Prompt user for file path
Console.Write("Enter the file path: ");
string filePath = Console.ReadLine();

// Prompt user for string
Console.Write("Enter the string to write: ");
string inputString = Console.ReadLine();

// Prompt user for integer
Console.Write("Enter the number of times to write the string: ");
int repeatTimes = Convert.ToInt32(Console.ReadLine());

// Create a new file and write the string n times
using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
{
    using (StreamWriter writer = new StreamWriter(fs))
    {
        for (int i = 0; i < repeatTimes; i++)
        {
            writer.WriteLine(inputString);
        }
    }
}

Console.WriteLine($"File '{Path.GetFileName(filePath)}' created and written successfully.");