namespace Chap9_ExceptZeroCatch;

class ExceptCatch
{
    static void Main()
    {
        int x = 10;
        int y = 0;

        try
        {
            int z = x / y;
        }
        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}