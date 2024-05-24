namespace Chap10_4_1;

class NullableType
{
    static void Main()
    {
        int? x = null;
        if (!x.HasValue)
        {
            Console.WriteLine("null");
        }
        x = 10;
        if (x.HasValue)
        {
            Console.WriteLine(x.Value);
        }
        Console.WriteLine(x == 10);
        Console.WriteLine(x + 10);
    }
}