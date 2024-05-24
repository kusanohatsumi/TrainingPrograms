namespace Chap6_ClsRefEase;

class ClsRefReSub
{
    static void Main()
    {
        var test = new TestClass();

        int e = 1;
        int f = 2;
        ref int g = ref e;

        g = 5;
        Console.WriteLine(e);               

        g = ref f;
        g = 10;

        Console.WriteLine(f);           
        Console.WriteLine(e);             
    }
}
