// Create the main directory "mydir"
string mainDirectory = "mydir";
Directory.CreateDirectory(mainDirectory);

// Create the subdirectory "mysubdir" inside "mydir"
string subDirectory = Path.Combine(mainDirectory, "mysubdir");
Directory.CreateDirectory(subDirectory);

// Get a list of files in "mydir"
string[] filesInMyDir = Directory.GetFiles(mainDirectory);

// Print out the names of the files
Console.WriteLine("Files in mydir:");
foreach (string file in filesInMyDir)
{
    Console.WriteLine(Path.GetFileName(file));
}