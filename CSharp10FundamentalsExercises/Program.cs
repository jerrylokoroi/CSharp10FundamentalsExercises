// Create a List of integers and add 7 elements
List<int> numbersList = new List<int> { 10, 20, 30, 40, 50, 60, 70 };

// Remove the 5th element (index 4)
numbersList.RemoveAt(4);

// Insert an element at the beginning
numbersList.Insert(0, 5);

// Print out all elements using a foreach loop
Console.WriteLine("List elements:");
foreach (int number in numbersList)
{
    Console.WriteLine(number);
}

