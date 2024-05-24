namespace ArrayLoop;

class ArrayLoop
{
    static void Main()
    {
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        for (var i = 0; i < weekDays.Length; i++)
        {
            Console.WriteLine(weekDays[i]);
        }

        foreach(string s in weekDays)
        {
            Console.WriteLine(s);
        }

        int[] a = { 1, 2, 3 };
        var sum = 0;
        for( var i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        Console.WriteLine(sum);
    }
}