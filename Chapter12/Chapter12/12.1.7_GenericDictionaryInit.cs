namespace Chap12_1_7;
class Medal
{
    readonly int gold;
    readonly int silver;
    readonly int bronze;

    public Medal(int g, int s, int b)
    {
        gold = g;
        silver = s;
        bronze = b;
    }

    public void Output()
    {
        Console.WriteLine("金：{0}, 銀：{1},銅：{2}", gold, silver, bronze);
    }

}

class GenericDictionaryInit
{
    static public void Main()
    {
        var win = new Dictionary<string, Medal>()
        {
            ["Japan"] = new Medal(20, 20, 8),
            ["China"] = new Medal(10, 5, 30),
            ["USA"] = new Medal(15, 10, 2),

        };


        var m = win["USA"];
        m.Output();

        try
        {
            m = win["Russia"];
            m.Output();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        win.TryGetValue("China", out m);
        m?.Output();

        win.TryGetValue("中国", out m);
        Console.WriteLine(m == null);

        if (win.ContainsKey("Japan"))
        {
            Console.WriteLine("存在");
        }

        win.TryGetValue("USA", out m);
        if (win.ContainsValue(m!))
        {
            Console.WriteLine("値あり");
        }

        foreach (KeyValuePair<string, Medal> kp in win)
        {
            Console.Write("{0} 　", kp.Key);
            kp.Value.Output();
        }

    }

}