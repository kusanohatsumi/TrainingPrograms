namespace Chap10_3_6;

class TupleCompare
{
    static void Main()
    {
        (int n, string name) t1 =(1, "sample");
        (int num, string str) t2 = (3, "テスト");

        Console.WriteLine(t1.n != t2.num || t1.name != t2.str);
        t1 = t2;
        Console.WriteLine(t1 == t2);
        Console.WriteLine(t1.n == t2.num && t1.name == t2.str);
    }
}