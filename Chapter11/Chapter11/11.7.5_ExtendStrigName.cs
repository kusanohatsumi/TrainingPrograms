using System.Runtime.CompilerServices;
using X;

namespace X
{
    public static class StringExtender
    {
        public static int HEx2Int(this string s)
        {
            return Convert.ToInt32(s.ToString());
        }

    }
}

class ExtendStringName
{
    static void Main()
    {
        var s = "D3";
        Console.WriteLine(s.HEx2Int());
    }
}