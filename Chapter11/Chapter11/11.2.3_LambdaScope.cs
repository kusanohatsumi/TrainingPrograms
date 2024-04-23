namespace Chap11_2_3;


class LambdScope
{
    public static void Main()
    {
        int b = 2;

        Action<int> Multi = n => { Console.WriteLine(n * b); };
        Multi(5);
    }
}