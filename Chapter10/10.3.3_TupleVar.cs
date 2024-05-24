using System.ComponentModel.DataAnnotations;

namespace Chap10_3_3;

class TupleVar
{
    static void Main()
    {
        int x = 1, y = 2;
        var t = (x, y);
        Console.WriteLine(t.x);
        Console.WriteLine(t.y);

        Console.WriteLine(t.Item1);
        Console.WriteLine(t.Item2);

    }
}