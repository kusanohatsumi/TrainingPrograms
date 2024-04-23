namespace Chap11_8_3;

class PatternComb
{
    public static void Main()
    {
        static string chkvalue(int v) => v switch
        {
            < 2 => "弱い",
            >= 2 and < 10 => "普通の",
            >= 10 and < 20 => "やや強い",
            >= 20 and < 30 => "強い",
            _ => "激しい"
        };

        for (int i = 1; i < 40; i+= 10)
        {
            Console.WriteLine($"雨量{i}mmは{chkvalue}雨です");
        }
    }
}