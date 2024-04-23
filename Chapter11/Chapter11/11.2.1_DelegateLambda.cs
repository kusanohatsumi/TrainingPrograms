namespace Chap11_2_1;

class DelegateLambda
{
    public static void Main()
    {
        Action<int> delVar = n => { Console.WriteLine(n); };

        delVar(123);
    }
}