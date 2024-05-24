namespace Chap9_4_1;

class ExceptReThrow2
{
    static void ExceptionMethod()
    {
        try
        {
            int[] a = new int[] { 3 };
            a[0] = 1;
            a[5] = 2; // 配列の範囲外にアクセス　＝例外

        }
        catch (Exception)
        {
            Console.WriteLine("最初の捕捉");
            throw;
        }
    }

    static void Main()
    {
        try
        {
            ExceptionMethod();
        }
        catch (Exception e)
        {
            Console.WriteLine("外側の捕捉");
            Console.WriteLine(e.Message);
        }
    }
}