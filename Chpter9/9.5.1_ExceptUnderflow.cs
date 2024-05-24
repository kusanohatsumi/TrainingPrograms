namespace Chap9_5_1;

class EceptUnderFlow
{
    static void Main()
    {
        float x = 1e35f;
        float y = 1e-35f;

        Console.WriteLine(x * x);
        Console.WriteLine(y * y);
    }
}