try
{
    Console.Write("Enter the first string: ");
    string firstString = Console.ReadLine();

    Console.Write("Enter the second string: ");
    string secondString = Console.ReadLine();

    string result = ConcatenateStrings(firstString, secondString);

    Console.WriteLine("Concatenated Result: " + result);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
    

    static string ConcatenateStrings(string str1, string str2)
{
    return str1 + str2;
}
