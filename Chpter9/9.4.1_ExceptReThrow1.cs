namespace Chap9_ExceptReThrow1;

class ExceptReThrow1
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
            throw new IndexOutOfRangeException();
        }
    }

    static void Main()
    {
        try
        {
            ExceptionMethod();
        }
        catch(Exception e)
        {
            Console.WriteLine("外側の捕捉");
            Console.WriteLine(e.Message);
        }
    }
}