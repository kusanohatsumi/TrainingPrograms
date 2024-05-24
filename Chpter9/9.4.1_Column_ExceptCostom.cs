namespace　Chap9_4_1_Column;

class BaseCostomException : Exception
{
    public BaseCostomException(string msg) : base(msg) { }
}

class CustomException : BaseCostomException
{
    public CustomException(string msg) : base(msg)
    {
    }
}

class ExceptCustom
{
    static void Main()
    {
        try
        {
            throw new CustomException("例外をスロー");
        }
        catch(BaseCostomException e)
        {
            Console.WriteLine("ユーザー定義");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}