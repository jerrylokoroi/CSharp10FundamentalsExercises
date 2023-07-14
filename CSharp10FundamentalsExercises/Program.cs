static int GetLengthOfString(string input)
{
    if (input == null)
    {
        return 0;
    }

    return input.Length;
}

string greetings = "I love writing codes!";
int length = GetLengthOfString(greetings);
Console.WriteLine("String length: " + length);

/*string nullText = null;
length = GetLengthOfString(greetings);
Console.WriteLine("String length: " + length);*/
