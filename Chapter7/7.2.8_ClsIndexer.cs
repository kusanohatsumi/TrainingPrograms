using System;
namespace Chap7_ClsIndexer;

class TestArray
{
    int[] array = new int[3];

    public int this[int index]
    {
        set
        {
            array[index] = value;
        }
        get
        {
            return array[index];
        }
    }
}

class ClsIndexer
{
    static void Main()
    {
        var t = new TestArray();

        t[0] = 5;
        t[1] = 10;
        t[2] = 15;

        Console.WriteLine(t[1]);

        var t2 = new TestArray()
        {
            [0] = 5,
            [1] = 10,
            [2] = 15
        };
        Console.WriteLine(t2[2]);
    }

}
