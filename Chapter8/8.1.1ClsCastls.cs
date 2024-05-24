class Music
{
    public virtual void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

class Song : Music
{
    public override void BaseInfo()
    {
        Console.WriteLine("Song");
    }
}

class Music2 : Music
{
    new public void BaseInfo()
    {
        Console.WriteLine("Music2");
    }
}

class ClsCast
{
    static void Main()
    {
        Music m = new Song(); 
        Song s = (Song)m;
        Console.WriteLine(m is Song);
        Console.WriteLine(m is Music2);
    }
}