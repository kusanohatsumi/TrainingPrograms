namespace Chap6_ClsOverloadErr;

class TestClass
{
    int AddNums(int a, int b)
    {
        return a + b;
    }
    /*
            long AddNums(int c, int d)
            {
                return c + d;
            }
    */
    long AddNums(out int a, int b)
    {
        a = b;
        return a;
    }
    /*
            long AddNums(ref int a, int b)
            {
                return a + b;
            }
    */
}
