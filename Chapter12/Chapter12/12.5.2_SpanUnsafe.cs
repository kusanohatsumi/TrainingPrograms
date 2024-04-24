namespace Chap12_5_2;

class SpanUnsafe
{
    static void Main()
    {
        try
        {
            unsafe
            {
                int* x = stackalloc int[3];
                x[5] = 1;
            }

            Span<int> sp = stackalloc int[] { 0, 1, 2 };
            sp[5] = 1;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}