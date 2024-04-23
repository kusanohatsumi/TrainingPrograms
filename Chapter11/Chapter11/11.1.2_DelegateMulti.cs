namespace Chap11_1_2
{
    delegate int SampleDel(int x);

    class TestClass
    {
        public int Testmethod1(int n)
        {
            return n * 10;
        }
        public int TestMethod2(int n)
        {
            return n * 20;
        }
    }

    class DelegteMulti
    {
        public static void Main()
        {
            var t = new TestClass();
            SampleDel? delVar = t.Testmethod1;

            delVar += t.TestMethod2;

            Console.WriteLine(delVar(10));

            delVar -= t.TestMethod2;

            if (delVar != null)
            {
                Console.WriteLine(delVar(10));
            }
        }

    }

}
