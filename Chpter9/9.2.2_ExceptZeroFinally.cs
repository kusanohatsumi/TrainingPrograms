namespace Chap9_ExceptZeroFinally;
class ExceptZeroFinally
{
static void Main()
{
    try
    {
        int a = 10;
        int b = 0;
        a /= b;
    }
    catch
    {
        Console.WriteLine("例外発生");
    }
    finally
    {
        Console.WriteLine("終了");
    }
}

}
