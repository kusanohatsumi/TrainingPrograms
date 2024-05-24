namespace Chap10_1_6;

class ArrayMethod
{
    public static void PrintArray(int[] a)
    {
        foreach (var x in a)
        {
            Console.WriteLine("{0}", x);           
        }
        Console.WriteLine("");
    }

    static void Main()
    {
        int[] arr = { 22, -14, 2, -17, 41, 6, 29 };

        PrintArray(arr);

        Array.Sort(arr);
        PrintArray(arr);

        Array.Reverse(arr);
        PrintArray(arr);
    }
}