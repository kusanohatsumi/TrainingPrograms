namespace Chap9_5;

class ExceptOverFlowUnChecked
{
    static void Main()
    {
        try
        {
            checked
            {
                ushort x = 300;
                byte y;

                y = unchecked((byte)x);
                Console.WriteLine(y);

                y = checked((byte)x);
                Console.WriteLine(y);
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}