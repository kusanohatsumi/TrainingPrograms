namespace Chap10_5_1;

class RecordInt1
{
    record Point
    {
        public String Name { get; set; } = "";
        public float Lat { get; set; } = default;
        public float Lon { get; set; } = default;
    }
    static void Main()
    {
        var p1 = new Point();
        Console.WriteLine(p1);

        p1 = new Point
        {
            Name = "大阪城",
            Lat = 34.687f,
            Lon = 135.526f
        };
        Console.WriteLine(p1);
    }
}