namespace Chap7_ClsIIndexerStr;

class ClsIIndexerStr
{
    static void Main()
    {
        var dict = new Dictionary<string, string>();

        dict["Mon"] = "月";
        dict["Tue"] = "火";  

        Console.WriteLine(dict["Mon"]);
    }
}

