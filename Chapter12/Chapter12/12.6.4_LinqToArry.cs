namespace Chap12_6_4;

class LinqToArray
{

    static void Main()
    {
        var names = new List<string>() {"Tiger", "Giants", "Dragons" };

        var result = (from n in names select n).ToArray();

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