// ClsHide.cs
using Chap7_ClsBase;

class Music
{
    public int Type = 0;

    public string Name = "Music";

    public void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

class song : Music
{
    public string Key = "C#";

    public void DrvInfo()
    {
        Console.WriteLine("Song");
    }
}

class ClsMusic
{
    static void Main()
    {
        var s = new song();
        Console.WriteLine(s.Key);
        s.DrvInfo();

        Console.WriteLine(s.Type);
        s.BaseInfo();

        var m = new Music();

        Console.WriteLine(m.Type);
        m.BaseInfo();
    }
}

