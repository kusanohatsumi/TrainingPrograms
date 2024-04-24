namespace Chap12_1_9;

class YieldEnum
{
    static void Main()
    {
        IEnumerable<int> factorial(int number)
        {
            for (int i = number; 0 < i; i--)
            {
                yield return i;
            }
        }
        foreach (var v in factorial(3))
        {
            Console.WriteLine(v);
        }
    }
}