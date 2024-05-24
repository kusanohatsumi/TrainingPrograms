namespace Chap8_ClsInterfaceMulti;

interface IBaseInterface1
{
    void Method1(int a);
}

interface IBaseInterface2
{
    void Method2(string s);
}

interface ISampleInterface : IBaseInterface1, IBaseInterface2
{
    void Method3();
}

class Sample : ISampleInterface
{
    public void Method1(int a)
    {
        Console.WriteLine(a);
    }

    public void Method2(string s)
    {
        Console.WriteLine(s);
    }

    public void Method3()
    {
        Console.WriteLine("method3");
    }
}

class ClsInterfaceMulti1
{
    static void Main()
    {
        var s = new Sample();
        s.Method1(123);           
        s.Method2("test");      
        s.Method3();             
    }
}
