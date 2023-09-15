string filePath = "output.bin";

// Write integers to the binary file
using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
{
    writer.Write(1);
    writer.Write(2);
    writer.Write(3);
    writer.Write(4);
}

// Read integers from the binary file
using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
{
    int num1 = reader.ReadInt32();
    int num2 = reader.ReadInt32();
    int num3 = reader.ReadInt32();
    int num4 = reader.ReadInt32();

    Console.WriteLine($"{num1}, {num2}, {num3}, {num4}");
}