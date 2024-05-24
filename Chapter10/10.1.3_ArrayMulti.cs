namespace Chap10_1_3;

class ArrayMult
{
    static void Main()
    {
        int[,] a = new int[,] { { 1, 2, }, { 3, 4, }, { 5, 6, } };

        int[,,] b =
        {
            { { 1, 2, 3 }, { 4, 5, 6 } },
            { { 7, 8, 9 }, { 10, 11, 12 } }
        };

        Console.WriteLine(a[0, 0]);
        Console.WriteLine(a[0, 1]);
        Console.WriteLine(a[1, 0]);
        Console.WriteLine(a[1, 1]);
        Console.WriteLine(a[2, 0]);
        Console.WriteLine(a[2, 1]);

        Console.WriteLine(b[0, 0, 0]);
        Console.WriteLine(b[0, 0, 1]);
        Console.WriteLine(b[0, 0, 2]);
        Console.WriteLine(b[0, 1, 0]);
        Console.WriteLine(b[0, 1, 0]);
        Console.WriteLine(b[0, 1, 2]);
        Console.WriteLine(b[1, 0, 0]);
        Console.WriteLine(b[1, 0, 1]);
        Console.WriteLine(b[1, 0, 2]);
        Console.WriteLine(b[1, 1, 0]);
        Console.WriteLine(b[1, 1, 1]);
        Console.WriteLine(b[1, 1, 2]);
    }
}