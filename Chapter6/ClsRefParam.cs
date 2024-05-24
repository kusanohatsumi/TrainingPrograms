namespace Chap6_ClsRefParam;

class TestClass
{
   
    public ref int TestFunc(ref int a)
    {
        a *= 3;
        return ref a;
    }
}

class ClsRefParam
{
    static void Main()
    {
        var test = new TestClass();

        int a = 5;

        ref int b = ref test.TestFunc(ref a);
        Console.WriteLine(a);  
        Console.WriteLine(b);  

        b = 10;
        Console.WriteLine(a);  
        Console.WriteLine(b);  
    }
}
