namespace Chap9_5;

class ExceptOverFlow
{
    static void Main()
    {
        try
        {
            short a = short.MaxValue;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}