namespace Chap7_ClsCapsule;

class Music
{
    int type = 0;                       
    protected string name = "Music";

    public void SetType(int type)
    {
        this.type = type;
    }

    public virtual void PrintName()
    {
        Console.WriteLine(type);
        Console.WriteLine(name);
    }
}

class Song : Music
{
    public override void PrintName()
    {
        this.name = "Song";        
        base.PrintName();           
    }
}

class ClsCapsule
{
    static void Main()
    {
        Song s = new Song();        
        s.SetType(1);             
        s.PrintName();          
    }
}
