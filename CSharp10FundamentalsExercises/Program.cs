// Create a 2D array of integers
int[,] array2D = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

// Get the dimensions of the array
int rows = array2D.GetLength(0);
int cols = array2D.GetLength(1);

// Print all elements in the array
Console.WriteLine("Array elements:");
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(array2D[row, col] + " ");
    }
    Console.WriteLine(); // Move to the next row
}

