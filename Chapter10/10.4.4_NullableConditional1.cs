
namespace Chap10_4_4;

public class Person
{
    public int No = 0;
    public string Name = "";
}

public class Team
{
    public Person? Member;
 
}

class MainClass
{
    public void Main()
    {
        var t = new Team();
        string? n = t.Member.Name;

        Console.WriteLine(n);
    }
}