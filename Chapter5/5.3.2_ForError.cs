namespace Chap5_3_2;

class ForError
{
    static void Main()
    {
        string[] j = { "グー", "チョキ", "パー" };

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(j[i]);
        }
    }
}