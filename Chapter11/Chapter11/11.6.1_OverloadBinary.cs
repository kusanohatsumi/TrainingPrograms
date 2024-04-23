namespace Chap11_6_1;

class TestClass
{
    private readonly int num;
    private readonly string str;

    public TestClass(int num, string str)
    {
        this.num = num;
        this.str = str;
    }

    public void Output()
    {
        Console.WriteLine(this.num);
        Console.WriteLine(this.str);
    }

    public static TestClass operator + ( TestClass a, TestClass b)
    {
        return new TestClass(a.num + b.num, a.str + b.str);
    }

}

class OverLoadBinary
{
    public static void Main()
    {
        var a = new TestClass(1, "演算子");
        var b = new TestClass(2, "オーバーロード");

        var c = a + b;
        c.Output();
    }
}
