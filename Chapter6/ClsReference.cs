namespace Chap6_ClsReference;

class TestClass
{
    public void TestFunc(ref int a)
    {
        a *= 3;

        Console.WriteLine(a);
    }
}

class ClsReference
{
    static void Main()
    {
        var test = new TestClass();
        int a = 5;               

        test.TestFunc(ref a);  
        Console.WriteLine(a);  
    }
}
