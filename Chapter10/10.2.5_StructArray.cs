namespace Chap10_2_5;

struct Player
{
    public string Name;
    public int Number;
    public string Position;

    public Player(int n, string s, string p)
    {
        Number = n;
        Name = s;
        Position = p;
    }
}

class Team
{
    int regularcnt;
    readonly Player[] regular = new Player[3];

    public bool AddRegular(Player p)
    {
        if (regularcnt < regular.Length)
        {
            regular[regularcnt++] = p;
            return true;
                
        }
        return false; 
    }

    public void ShowRgular()
    {
        foreach (var p in regular)
        {
            if (p.Name != null)
            {
                Console.WriteLine("{0} {1} {2}", p.Name, p.Number, p.Position);              
            }
        }
    }

    public Player GetRegular(int ix)
    {
        try
        {
            return regular[ix];
        }
        catch
        {
            return new Player();
        }
    }
}

class StructArray
{
    static void Main()
    {
        var t = new Team();

        t.AddRegular(new Player(53, "青星", "センター"));
        t.AddRegular(new Player(6, "鉄本", "レフト"));
        t.AddRegular(new Player(1, "島谷", "ショート"));
        t.AddRegular(new Player(39, "矢田", "キャッチャー"));

        t.ShowRgular();

        var p = t.GetRegular(1);
        Console.WriteLine(p.Name);

        p = t.GetRegular(5);
        Console.WriteLine(p.Name);


    }
}

