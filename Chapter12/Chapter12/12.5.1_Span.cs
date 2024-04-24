namespace Chap12_5_1;

class Span
{
    static void Main()
    {
        var dartaary = new int[] { 2020, 7, 24, 9, 0 };

        var span = new Span<int>(dartaary, 1, 2);

        foreach (var d in span)
        {
            Console.Write(d);
        }

        span[0] = 5;

        foreach (var d in dartaary)
        {
            Console.Write(d);
        }

        var span2 = "Microsoft".AsSpan().Slice(2, 1);
        Console.Write(span2[0]);
    }
}