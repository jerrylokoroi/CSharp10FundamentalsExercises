Public void Main()
{
    int a = 5;
    int b = 10;

    Console.WriteLine($"Before swap: a = {a}, b = {b}");

    Swap(ref a, ref b);

    Console.WriteLine($"After swap: a = {a}, b = {b}");
}

Public void Swap(ref int x, ref int y){
    (x, y) = (y, x);
}
