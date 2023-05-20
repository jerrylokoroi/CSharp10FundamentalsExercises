
Console.WriteLine("Enter a letter: ");
char letter = Console.ReadLine().ToLower()[0];

string result = (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
    ? "Vowel"
    : "Consonant";

Console.WriteLine(result);







