using System.Diagnostics.CodeAnalysis;

namespace Chap11_8_1;

class PatternSwitch
{
    static void Main()
    {
        var month = DateTime.Now.Month;

        var str = month switch
        {
            1 => "睦月",
            2 => "如月",
            3 => "弥生",
            _ when month == 7 || month == 8 => "夏休み",
            _ => month + "月"
        };
        Console.WriteLine(str);
    }
}