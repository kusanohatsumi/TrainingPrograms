namespace Chap11_2_2;

class LambdaDestruction
{
    public static void Main()
    {
        Func<int, int, int> func1 = (_, p) => _ * p;
        Func<int, int, int> func2 = (_, _) => 0;

        Console.WriteLine(func1(5, 2));
        Console.WriteLine(func2(5, 2));

    }
}