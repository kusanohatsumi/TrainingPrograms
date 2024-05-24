namespace Chap6_ClsNameParam;
class TestClass
{
    
    public int CalcAdd(int a, int b)
    {
        return a + b; 
    }
    public int CalcAdd2(int a, int b, int c)
    {
        return a + b + c; 
    }
}

class ClsNameParam2
{
    static void Main()
    {
        var test = new TestClass();

        int a = test.CalcAdd2(3, c: 4, b: 2);

        int b = test.CalcAdd2(a: 3, 4, 1);

        Console.WriteLine(a);              
        Console.WriteLine(b);              
    }
}
