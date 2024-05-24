namespace Chap8_ClsOverride2;

class Music
{
    public virtual void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

class Music2 : Music
{
    new public void BaseInfo()
    {
        Console.WriteLine("Music2");
    }
}

class ClsOverride2
{
    static void Main()
    {
        Music m;

        m = new Music2();
        m.BaseInfo();

    }
}