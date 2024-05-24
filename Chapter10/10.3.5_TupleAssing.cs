namespace Chap10_3_5;
class TupleAssing
{
    static void Main()
    {
        (int n0, string name) t1 = (1, "sample");
        (byte n, string name) t2 = (3, "テスト");

        t1 = t2;
        Console.WriteLine(t1.name);
    }
}