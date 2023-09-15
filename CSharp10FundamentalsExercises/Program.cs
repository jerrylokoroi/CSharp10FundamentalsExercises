// Prompt user for a sentence
using System.Text.RegularExpressions;

Console.Write("Enter a sentence: ");
string inputSentence = Console.ReadLine();

// Define a regular expression to split the sentence into words
string pattern = @"\b\w+\b";

// Use Regex.Matches to find all matches of the pattern
MatchCollection matches = Regex.Matches(inputSentence, pattern);

// Count the number of matches (words)
int wordCount = matches.Count;

Console.WriteLine($"The sentence contains {wordCount} words.");