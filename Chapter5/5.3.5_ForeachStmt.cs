namespace Chap5_3_5;

class ForeachStmt
{
    static void Main()
    {
        string[] j = { "グー", "チョキ", "パー" };
        foreach (string str in j)
        {
            Console.WriteLine(str);
        }
    }

}