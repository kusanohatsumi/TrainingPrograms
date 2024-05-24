namespace Chap10_2_2;


struct Simple
{
    public int Number;
    public string Name;

    public Simple(int n, string s)
    {
        Number = n;
        Name = s;
    }

    public Simple()
    {
        Number = -1;
        Name = "規定";
    }
}

class MainClass
{
    static void Main()
    {
        var s0 = new Simple();
        Console.WriteLine(s0.Number);
        Console.WriteLine(s0.Name);

        Simple s1 = default;
        Console.WriteLine(s1.Number);
        Console.WriteLine(s1.Name);

        var s2 = new Simple(1, "testname");
        
        Console.WriteLine(s2.Number);
        Console.WriteLine(s2.Name);

        Simple ss;

    }
}
