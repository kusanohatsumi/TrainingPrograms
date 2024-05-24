namespace Chap10_5_5;

class RecordStruct
{
    record struct Rstruct(int X, int Y);
    record class Rclass(int X, int Y);
    struct NormalStruct
    {
        public int X = -1;
        public int Y = -1;
        public NormalStruct() { }
    }

    static void Main()
    {
        var rs = new Rstruct { X = 2 };
        Console.WriteLine(rs);

        rs.Y = 2;
        Console.WriteLine(rs);

        var rc = new Rclass(0, 0);
        Console.WriteLine(rc);

        var ns = new NormalStruct { X = 2 };
        Console.WriteLine(ns.X);
        Console.WriteLine(ns.Y);
        Console.WriteLine(ns);
    }
}
