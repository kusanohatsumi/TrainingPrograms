static void Main()
{
    int a = 5;
    object obj;

    obj = a;
    var b = (int)obj;

    Console.WriteLine(b);

    Console.WriteLine(obj is double);
    Console.WriteLine(obj is int);
}
