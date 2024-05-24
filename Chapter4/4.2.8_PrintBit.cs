namespace Chap4_2_8;

class PrintBit
{
    static void Main()
    {
        int a = 0b0000_0010;
        int b = 0b0000_1111;

        Console.WriteLine(Convert.ToString(a & b, 2));
        Console.WriteLine(Convert.ToString(a | b, 2));
        Console.WriteLine(Convert.ToString(a ^ b, 2));
        Console.WriteLine(Convert.ToString(~a, 2));

    }

}