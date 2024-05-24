namespace Chap8_ClsAbstract;

abstract class Music
{
    public abstract void GetInfo();   
}

class Song : Music
{
    public override void GetInfo()   
    {
        Console.WriteLine("Song");
    }
}

class ClsAbstract
{
    static void Main()
    {
        var s = new Song();
        s.GetInfo();               
    }
}
