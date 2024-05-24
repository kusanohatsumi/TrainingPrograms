namespace Chap6_ClsNameParam;
class ClsNameParam1
{
    static void Main()
    {
        var test = new TestClass();

        int p = 4;

        int a = test.CalcAdd(a: 3, b: p);   
        int b = test.CalcAdd(b: p, a: 3);   

        Console.WriteLine(a);               
        Console.WriteLine(b);               
    }
}
