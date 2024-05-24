namespace Chap4_2_8;

class PrintShift
{
    static void Main()
    {
        int a = 162;
        Console.WriteLine(Convert.ToString(a, 2));
        Console.WriteLine(Convert.ToString(a << 3, 2));
        Console.WriteLine(Convert.ToString(a >> 3, 2));
    }

}