namespace Chap6_ClsRefEase;

class TestClass
{
    public int CalcAdd(int a, int b)
    {
        return a + b;
    }
    public int CalcAdd2(int a, int b, int c)
    {
        return a + b + c; 
    }

    public int RefCalcAdd(in int a, in int b)
    {
        ref readonly int ra = ref a;
        ref readonly int rb = ref b;

        return ra + rb;
    }

}

class ClsRefEase
{
    static void Main()
    {
        var test = new TestClass();

        int c = 1;
        int d = 2;

        ref int x = ref c < d ? ref c : ref d;

        x = 5;
        Console.WriteLine(c);            
    }
}
