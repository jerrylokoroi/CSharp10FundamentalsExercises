// Create an array of strings and initialize with favorite movies
string[] favoriteMovies = { "The Mummy", "Extraction", "London Has Fallen", "Mad Max" };

// Add another favorite movie using Array.Resize
Array.Resize(ref favoriteMovies, favoriteMovies.Length + 1);
favoriteMovies[favoriteMovies.Length - 1] = "Apocalyptus";

// Print out the second element using the indexer (index 1)
Console.WriteLine("Second favorite movie: " + favoriteMovies[1]);

// Sort the array in alphabetical order
Array.Sort(favoriteMovies);

// Print the sorted array
Console.WriteLine("Favorite movies in alphabetical order:");
foreach (string movie in favoriteMovies)
{
    Console.WriteLine(movie);
}

