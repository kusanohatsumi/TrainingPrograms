namespace Chap8_ClsInterface;

interface IPoint
{
    int Px
    {
        get; set;
    }

    int Py
    {
        get; set;
    }
}

class ReversePoint : IPoint
{
    int x;
    int y;

    public ReversePoint(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int Px
    {
        get { return -x; }
        set { x = value; }
    }
    public int Py
    {
        get { return -y; }
        set { y = value; }
    }
}

class ClsInterface2
{
    public static void DisplayPoint(IPoint point)
    {
        Console.WriteLine("x={0},y={1}", point.Px, point.Py);
    }

    static void Main()
    {
        var p1 = new ReversePoint(-12, -300);

        Console.WriteLine(p1.Px);  
        Console.WriteLine(p1.Py);  

        var p2 = new ReversePoint(12, 300);

        DisplayPoint(p2); 

    }
}
