namespace Chap11_2_3_2;


class LambdaLocal
{
    public static void Main()
    {
        Action CreateLambda(int n)
        {
            int b = 2;
            return () => { Console.WriteLine(n * b); };
        }
        Action action = CreateLambda(3);
        action();
    }
}