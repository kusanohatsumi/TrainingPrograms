namespace Coalescing;

#nullable disable

class NullableCoalescing
{
    static void Main()
    {
        int? a = null;
        Console.WriteLine(a ?? 10);

        a = 5;
        Console.WriteLine(a ?? 10);

        string s = null;
        Console.WriteLine(s ?? "Empty");

        s ??= "空の文字列";
        Console.WriteLine(s);
    }
}