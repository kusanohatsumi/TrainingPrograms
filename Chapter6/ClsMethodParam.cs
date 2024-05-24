namespace Chap6_ClsMethod;

class TestClass
{
    
    public int CalcAdd(int a, int b)
    {
        return a + b; 
    }
}

class ClsMethodParam
{
    static void Main()
    {
        var test = new TestClass();

        int p = 4;
        int a = test.CalcAdd(3, p);   

        Console.WriteLine(a);         
    }
}
