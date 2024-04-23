
class TestClass
{
    private readonly int num;
    private readonly string str;

    public TestClass(int num, string? str)
    {
        this.num = num;
        this.str = str;
    }

    internal int BMI()
    {
        throw new NotImplementedException();
    }

    public static bool operator true(TestClass a)
    {
        return (a.num != 0) && (a.str != null);
    }

    public static bool operator false(TestClass a)
    {
        return (a.num == 0) && (a.str == null);
    }
}


class OverLoadTrue
{
    public static void BoolTest(TestClass t)
    {
        if (t)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public static void Main()
    {
        var a = new TestClass(1, "演算子");
        var b = new TestClass(2, null);

        BoolTest(a);
        BoolTest(b);
    }
}