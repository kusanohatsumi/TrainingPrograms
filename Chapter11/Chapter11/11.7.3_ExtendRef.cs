namespace Chap11_7_3;

public struct Point
{
    public double lat, lon;

    public Point(double y, double x)
    {
        lon = y;
        lat = x;
    }

}

public static class GetMeshCode
{
    public static int Mesh1(in this Point p)
        => (int)(p.lat * 1.5) * 100 + (int)(p.lon - 100);
}

class ExtendRef
{
    public static void Main()
    {
        var p = new Point(34.687426, 135.525845);

        Console.WriteLine(p.Mesh1());
    }
}