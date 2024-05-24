namespace Chap9_ExceptThrow;

class CustomException : Exception
{
    public CustomException(string msg) : base(msg)
    {

    }
}

class ExceptThrow
{
    static void Main()
    {
        try
        {
            throw new CustomException("例外をスロー");
        }
        catch(CustomException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}