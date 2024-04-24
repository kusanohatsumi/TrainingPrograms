namespace Chap12_6_4;

class LinqDeferrd
{
    static void Main()
    {
        var names = new List<string>() { "Tiger", "Giants", "Drgons" };

        var result = from n in names select n;

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("");
            
        string tmp = names[1];
        names[1] = names[2];
        names[2] = tmp;

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }


}