namespace Chap5_3_4;

class DoStmt
{
    static void Main()
    {
        int i = 10;
        do
        {
            Console.WriteLine(++i);
        }
        while (i < 5);
    }

}