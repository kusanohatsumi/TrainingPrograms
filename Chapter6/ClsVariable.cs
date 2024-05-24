namespace Chap6_ClsVariable;

class TestClass
{
    public int SumAll(params int[] numary)
    {
        int sum = 0;

        foreach (int n in numary)
        {
            sum += n;
        }

        return sum; 
    }
}

class ClsVariable
{
    static void Main()
    {
        var test = new TestClass();

        Console.WriteLine(test.SumAll(1, 2));       
        Console.WriteLine(test.SumAll(5, 10, 15));  
        Console.WriteLine(test.SumAll());           
    }
}
