namespace Chap9_ExceptWhen1;

class ExceptWhen1
{
    static void Main()
    {
        try
        {
            throw new Exception("error");
        }
        catch(Exception e) when (e.Message == "error")
        {
            Console.WriteLine("エラー発生");
        }
        catch(Exception e)
        {
            Console.WriteLine("その他の例外");
        }
    }
}