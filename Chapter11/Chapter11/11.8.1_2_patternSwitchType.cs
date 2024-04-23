namespace Chap11_8_1;

class PatternSwitchType
{
    static void Main()
    {
        object test = "test";
        var str = test switch
        {
            int => "int",
            long => "long",
            string => "string",
            _ => "none"
        };
        Console.WriteLine(str);
    }
}