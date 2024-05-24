namespace Chap10_5_1;

class RecodInt2
{
    record Point(float Lat, float Lon);
    static void Main()
    {
        var p1 = new Point(34.687f, 135.526f);
        Console.WriteLine(p1.Lat);
    }
}