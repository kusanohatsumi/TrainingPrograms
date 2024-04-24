namespace Chap12_6_2;

class LinqFrom
{
    static void Main()
    {
        var result = from f in System.IO.Directory.GetFiles(@"c:\") select f;

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}