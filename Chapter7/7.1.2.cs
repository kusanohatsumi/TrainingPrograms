namespace Chap7_ClsBase;

class BaseClass
{
    public BaseClass(string s)
    {
        Console.WriteLine(s);
    }
}

class DerivedClass : BaseClass
{
    public DerivedClass(string s1, string s2) : base(s2)
    {
        Console.WriteLine(s1);
    }
}

class ClsBase
{
    static void Main()
    {
        var c = new DerivedClass("Derived", "Base");
    }
}
