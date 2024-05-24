namespace Chap5_5_2;

class Continue
{
    static void Main()
    {
        Console.WriteLine("chapter5.5.2");
        for (int i = 0; true; i++)
        {
            if (i < 8)
            {
                continue;
            }
            else if (i == 10)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}