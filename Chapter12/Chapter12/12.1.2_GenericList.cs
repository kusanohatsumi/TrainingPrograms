namespace Chap12_1_2;

class GenericList
{
    static void Main()
    {
        List<string> slist = new();

        slist.Add("Hellow");
        slist.Add("World");

        string s = slist[1];

        Console.WriteLine(s);
    }
}