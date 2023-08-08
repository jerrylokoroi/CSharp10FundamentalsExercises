// Create an array of doubles
double[] values = { 2.5, 3.8, 1.7, 4.2, 5.0 };

// Calculate the sum of all elements
double sum = 0.0;
for (int i = 0; i < values.Length; i++)
{
    sum += values[i];
}

// Calculate the average
double average = sum / values.Length;

// Print the average
Console.WriteLine($"Average: {average}");

