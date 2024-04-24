namespace Chap12_1_9;

class YieldReturn
{
    static void Main()
    {
        IEnumerable<int> factorial(int number)
        {
            if ((number < 1) || (100 < number)) 
            {
                Console.WriteLine("error");
                yield break;
            }
            for(int i = number; 0 < i; i--)
            {
                yield return i;
            }
        }
        foreach (var v in factorial(101))
        {
            Console.WriteLine(v);
        }
    }
}