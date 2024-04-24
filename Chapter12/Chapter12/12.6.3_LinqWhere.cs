namespace Chap12_6_3;

class LinqWhere
{
    static void Main()
    {
        var result = from f in System.IO.Directory.GetFiles(@"c:\")
                     where f.Length < 10
                     select f;

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}