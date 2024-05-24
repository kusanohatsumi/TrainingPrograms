namespace Chap10_5_4;

class RecordInheritance
{
    record Point(String Name, float Lat, float Long);
    record NewPoint1(float El) : Point("初期値", 0f, 0f);
    record NewPoint2(String Name, float Lat, float Lon, float El) : Point(Name, Lat, Lon);

    static void Main()
    {
        var p1 = new NewPoint1(0f);
        Console.WriteLine(p1);

        var p2 = new NewPoint2("甲子園", 34.721279f, 135.361554f, 1.8f);
        Console.WriteLine(p2.Name);
    }
}