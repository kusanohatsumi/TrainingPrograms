namespace Chap11_7_4;

public static class StringExtender
{
    public static int Hex2Int(this string s)
    {
        return Convert.ToInt32(s,16);
    }
}

class ExtendString
{
    static void Main()
    {
        var s = "D3";
        Console.WriteLine(s.Hex2Int());
    }
}