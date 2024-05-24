namespace Chap5_5_1;

class Break
{
    static void Main()
    {
        for (int i = 0; true; i++)
        {
            if (i == 3)
            {
                break;
            }
            Console.WriteLine(i);
        }

    }

}