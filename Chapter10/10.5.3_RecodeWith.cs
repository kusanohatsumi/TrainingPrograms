namespace Chap10_5_3;


class RecordWith
{
    record Point(String Name, float Lat, float Lon );

    static void Main()
    {
        var p1 = new Point("初期地点", 0f, 0f);

        var p2 = p1 with { Name = "どこか" };
        var p3 = p1 with { Lat = 34.687f, Lon = 135.526f };
        var p4 = p1 with { };

        Console.WriteLine( p2 );
        Console.WriteLine( p3 );
        Console.WriteLine( p4 );
        Console.WriteLine(p1 == p4);
    }
}