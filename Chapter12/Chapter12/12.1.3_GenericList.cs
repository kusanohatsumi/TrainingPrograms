namespace Chap12_1_3;

class GenericListInit
{
    static void Main()
    {
        var list = new List<string>() { "Hellow,", "World", "Good-Bye"};

        foreach (var s in list)
        {
            Console.WriteLine(s);
        }

    }
}