namespace Chap5_2_1;

class IfStmt2
{
    static void Main()
    {
        int x = 15;
        if (x < 10)
        {
            x *= 10;
        }
        else
        {
            x = -x;
        }
        Console.WriteLine(x);

    }

}