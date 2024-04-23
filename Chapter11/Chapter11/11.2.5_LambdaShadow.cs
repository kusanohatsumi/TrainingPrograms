namespace Chap11_2_5;

class LambdaShadow
{
    public static void Main()
    {
        int b = 2;
        LocalFunctionShadow(3);

        static void LocalFunctionShadow(int b)
        {
            Console.WriteLine(b * b);
        }
    }
}