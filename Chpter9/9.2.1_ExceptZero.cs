namespace Chap9_ExceptZero;
class ExceptZero
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;

            Console.WriteLine("try");

            a /= b;
            Console.WriteLine("エラー");
        }
        catch
        {
            Console.WriteLine("例外発生");
        }
    }

}
