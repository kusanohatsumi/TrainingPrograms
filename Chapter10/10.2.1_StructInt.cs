namespace Chap10_2_1;

struct Simple
{
    public int Number;
    public string Name;
}

class MainClass
{
    static void Main()
    {
        Simple ss;

        ss.Number = 0;
        ss.Name = "Test";

        Console.WriteLine(ss.Number);
        Console.WriteLine(ss.Name);
    }
}