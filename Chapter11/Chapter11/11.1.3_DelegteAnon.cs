namespace Chap11_1_3
{
    delegate void SmpleDel(int x);

    class DelegateAnon
    {
        public static void Main()
        {
            var delVar = delegate (int n) { Console.Write(n); };
            delVar(123);
        }
    }
}
