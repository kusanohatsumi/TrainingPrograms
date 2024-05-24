namespace Chap9_5;

class ExceptNestChecked
{
    static void Main()
    {
        try
        {
            ushort x = 300;
            byte y;

            unchecked
            {
                y = (byte)x;
                Console.WriteLine(y);

                checked
                {
                    y = (byte)x;
                    Console.WriteLine(y);
                }
            }

        }
        catch(OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}