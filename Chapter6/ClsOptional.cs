namespace Chap6_ClsOptional;

class TestClass
{
    public void PrintName(int no, string name = "nanashi")
    {
        Console.WriteLine(no + "→" + name);
    }
}

class ClsOptional
{
    static void Main()
    {
        var test = new TestClass();

        test.PrintName(10); 
    }
}
