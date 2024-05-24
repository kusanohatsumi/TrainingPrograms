namespace Chap8_ClsInterfaceDef;

interface ISample1
{
    void MethodA() => Console.WriteLine("MethodA");
    void MethodB();
}

public class A : ISample1
{
    public void MethodB() => Console.WriteLine("MethodB");
}
class B : ISample1
{
    public void MethodA() => Console.WriteLine("B MethodA");
    public void MethodB() => Console.WriteLine("MethodB");
}

class ClsInterfaceDef1
{
    static void Main()
    {
        var c1 = new A();
        c1.MethodB();            

        ((ISample1)c1).MethodA(); 

    }
}

