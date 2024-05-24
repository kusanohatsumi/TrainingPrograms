namespace Chap8_ClsInterfaceDef;

class ClsInterfaceDef2
{
    static void Main()
    {
        var c2 = new B();
        c2.MethodA();        

        ((ISample1)c2).MethodA();  
    }
}

