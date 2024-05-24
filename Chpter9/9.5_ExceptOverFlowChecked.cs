namespace Chap9_5;

class ExceptOverFlowChecked
{
    static void Main()
    {
        try
        {
            checked
            {
            short a = short.MaxValue;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}