namespace Chap12_2_3;

class StringConst
{
    static void Main()
    {
        const string C1 = "日経";
        const string C2 = $"{C1}{""}太郎";
        const string C3 = $"私の名前は{C2}です。";

        Console.WriteLine(C3);
    }
}