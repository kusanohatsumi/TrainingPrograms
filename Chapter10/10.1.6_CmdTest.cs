namespace Chap10_1_6;

class CmdTest
{
    static void Main(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("パラメータ{0} : {1}", i, args[i]);
        }
    }
}