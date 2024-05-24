
namespace Chap10_5_2;

record Point(String Name, float Lat, float Long);

class CPoint
{
    public String Name { get; init; } = "";
    public float Lat { get; init; } = default;
    public float Lon { get; init; } = default;
}
class RecordEquals
{
    static void Main()
    {
        var c1 = new CPoint();
        var c2 = new CPoint();
        Console.WriteLine(c1 == c2);
        Console.WriteLine(c1 != c2);

        var p1 = new Point("", 0f, 0f);
        var p2 = new Point("", 0f, 0f);
        Console.WriteLine(p1 == p2);
        Console.WriteLine(p1 != p2);
    }
}