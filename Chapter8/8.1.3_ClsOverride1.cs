namespace Chap8_ClsOverride;

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

class Symphony : Music
{
    public override void BaseInfo()
    {
        Console.WriteLine("symphony");
    }
}

class ClsOverride1
{
    static void Main()
    {
        Music m;

        m = new Song();
        m.BaseInfo();

        m = new Symphony();
        m.BaseInfo();
    }
}