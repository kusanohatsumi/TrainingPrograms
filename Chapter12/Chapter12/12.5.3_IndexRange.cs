namespace Chap12_5_3;

class IndexRange
{
    static void Main()
    {
        var dartaary = new int[] { 2020, 7, 24, 9, 0 };

        Console.WriteLine(dartaary[^3]);

        var span = dartaary.AsSpan()[1..3];

        foreach (var d in span)
        {
            Console.Write(d);
        }
    }

}