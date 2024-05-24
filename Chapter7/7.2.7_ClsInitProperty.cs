namespace Chap7_ClsInitProperty;
public class TestClass
{
    public string GetProp { get; }      
    public string InitProp { get; init; }

    public TestClass()
    {
        this.GetProp = "";
        this.InitProp = "";
    }

    public TestClass(string gv, string iv)
    {
        this.GetProp = gv;
        this.InitProp = iv;
    }

    public void TestMethod(string gv, string iv)
    {
    }
}

public class ClsInitProperty
    {
    static void Main()
    {
        var t1 = new TestClass("p1", "p2");

        var t2 = new TestClass
        {
            InitProp = "a",
        };
    }
}

