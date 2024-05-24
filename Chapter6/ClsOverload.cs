namespace Chap6_ClsOverload;

class TestClass
{
    long AddNums(int a, int b)
    {
        return a + b;
    }

    long AddNums(int a, int b, int c)
    {
        return a + b + c;
    }

    long AddNums(long a, long b)
    {
        return a + b;
    }

    long AddNums(ref int a, int b)
    {
        return a + b;
    }
}
