namespace Chap12_6;

class LinqBasic
{
    static void Main()
    {
        int[] num = { 1, 2, 9, 28, 30, 31, 15, 42 };

        var numsQuery = from n in num
                        where n < 30
                        select n;

        foreach( var x in numsQuery)
        {
            Console.Write("{0}, ", x);
        }
        Console.WriteLine();

        var numsMethod = num.Where(x => (x % 3) == 0);

        foreach(var x in numsMethod)
        {
            Console.Write("{0}, ", x);
        }
    }
}