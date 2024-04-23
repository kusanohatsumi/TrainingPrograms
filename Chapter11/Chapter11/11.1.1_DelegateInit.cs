namespace Chap11_1_1;

delegate void SampleDel(int x);

class DelegateInit
{
    static void TestMethod(int n)
    {
        Console.WriteLine(n);
    }

    public static void Main()
    {
        SampleDel delVar;

        delVar = new SampleDel(TestMethod);

        delVar(123);
    }
}