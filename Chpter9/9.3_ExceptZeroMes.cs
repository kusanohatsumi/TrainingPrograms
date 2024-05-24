namespace Chap9_ExceptZeroMes;

class ExceptZeroMes
{
    static void Main()
    {
        try
        {
            int a = 0;
            int b = 0;
            a /= b;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}