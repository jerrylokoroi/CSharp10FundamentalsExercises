// Create source.txt and write text to it
using (StreamWriter writer = new StreamWriter("source.txt"))
{
    writer.WriteLine("Hello again, world!");
}

// Copy source.txt to destination.txt
File.Copy("source.txt", "destination2.txt");

// Rename destination.txt to newname.txt
File.Move("destination.txt", "newname2.txt");

// Verify if both operations were successful
bool sourceExists = File.Exists("source.txt");
bool destinationExists = File.Exists("destination.txt");
bool newNameExists = File.Exists("newname.txt");

Console.WriteLine($"source.txt exists: {sourceExists}");
Console.WriteLine($"destination.txt exists: {destinationExists}");
Console.WriteLine($"newname.txt exists: {newNameExists}");