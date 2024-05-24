using System;
namespace Chap8_ClsInterMem;

interface IBaseInterface1
{
    void PrintOut(string s);
}

interface IBaseInterface2
{
    void PrintOut(string t); 
}

class SampleClass : IBaseInterface1, IBaseInterface2
{
    public void PrintOut(string s)
    {
        Console.WriteLine("Interface0 : " + s);
    }

    void IBaseInterface1.PrintOut(string s)
    {
        Console.WriteLine("Interface1 : " + s);
    }

    void IBaseInterface2.PrintOut(string s)
    {
        Console.WriteLine("Interface2 : " + s);
    }
}

class ClsInterMem
{
    static void Main()
    {
        var sc = new SampleClass();

        sc.PrintOut("0");               

        IBaseInterface1 ifc1 = (IBaseInterface1)sc; 
        ifc1.PrintOut("1");             

        IBaseInterface2 ifc2 = (IBaseInterface2)sc;  
        ifc2.PrintOut("2");               
    }
}
