namespace Chap12_1_12;

class TestMethod
{
    public void Info<T>(in T p)
    {
        Console.WriteLine("データ型は{0}です", p?.GetType());
    }
}

class TestClass<Type>
{
    private Type[] ary = new Type[2];
    public Type? Add(int idx, Type p)
    {
        if (0 <= idx && idx < ary.Count())
        {
            ary[idx] = p;
            return ary[idx];
        }
        return default;
    }
}

class GenericMethod
{
    static void Main()
    {
        var m = new TestMethod();
        m.Info("123");
        m.Info(m);

        var t = new TestClass<string>();
        Console.WriteLine(t.Add(1, "test"));
    }
}