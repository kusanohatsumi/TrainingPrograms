namespace Chap6_ClsStaticClass;

static class TestClass
{
    public static int a;

    static TestClass()
    {
        a = 5;
    }

    public static void Display()
    {
        Console.WriteLine(a); 
    }
}

class ClsStaticClass
{
    static void Main()
    {
        TestClass.Display(); 
    }
}
