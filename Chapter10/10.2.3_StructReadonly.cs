namespace Chap10_2_3;

readonly struct ReadonlyStruct
{
    public readonly int A;
    public readonly string B;
    public double C { get; }

    public ReadonlyStruct(int a, string b, double c)
    {
        A = a;
        B = b;
        C = c;
    }
}

class MainClass
{
    static void Main()
    {
        var s = new ReadonlyStruct(1, "a", 2);
        //s.A = 3;
    }
}