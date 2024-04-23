namespace Chap11_1_1_2;

delegate void SampleDel(int x);

class TestClass
{
    public void TestMethod1(int n)
    {
        Console.WriteLine(n);
    }

    public static void TestMethod2(int n)
    {
        Console.WriteLine(n * 2);
    }
}

class DelegateStatic
{
    public static void Main()
    {
        var t = new TestClass();
        SampleDel delVar = t.TestMethod1;
        delVar(123);

        delVar = TestClass.TestMethod2;

        delVar(123);
    }
}
