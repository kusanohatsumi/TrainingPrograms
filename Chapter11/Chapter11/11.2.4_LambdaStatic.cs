namespace Chap11_2_4;

class LambdaStatic
{
    public static void Main()
    {
        int b = 2;

        void LocalFunction(int n)
        {
            Console.WriteLine(n * b);
            b++;
        }

        static void LocalFunctionStatic(int n)
        {
            Console.WriteLine(n);
        }


        Action<int> action = static x => Console.WriteLine(x * 2);
        Action<int> actiondele = static delegate (int x)
        {
            Console.WriteLine(x * 2);
        };

        LocalFunction(3);
        Console.WriteLine(b);
        LocalFunctionStatic(3);
        action(5);
    }   
}