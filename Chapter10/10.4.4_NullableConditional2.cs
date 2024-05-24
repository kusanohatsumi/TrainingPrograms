
namespace Chap10_4_4;

public class Person2
{
    public int No = 0;
    public string Name = "";
}

public class Team2
{
    public Person? Member;

}

class MainClass2
{
    public void Main()
    {
        var t = new Team();
        string? n = t.Member?.Name;

        Console.WriteLine(n);

        var t2 = new Team();
        string n2 = t2.Member?.Name ?? "nothing";
        Console.WriteLine(n2);
    }
}