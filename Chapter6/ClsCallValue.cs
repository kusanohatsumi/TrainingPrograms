namespace Chap6_ClsCallValue;

class TestClass
{
    
    public void TestFunc(int a)
    {
        
        a *= 3;

        Console.WriteLine(a);
    }
}

class ClsCallValue
{
    static void Main()
    {
        var test = new TestClass();
        int a = 5;

        test.TestFunc(a);     
        Console.WriteLine(a); 
    }
}
