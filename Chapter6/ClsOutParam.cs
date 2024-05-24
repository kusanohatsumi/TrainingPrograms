namespace Chap6_ClsOutParam;

    class TestClass
    {
       
        public void TestFunc(int a, out int b, out int c)
        {
            b = a * a;
            c = a * a * a;
        }
    }

class ClsOutParam
{
    static void Main()
    {
        var test = new TestClass();

        int x, y;                  

        test.TestFunc(3, out x, out y);



        Console.WriteLine(x);    
        Console.WriteLine(y);  
    }
}

