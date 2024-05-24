namespace Chap3_6_1;

class InitEnum
{
    enum Day
    {
        Sun, Mon, Tue = 10,
        Wed, Thu, Fri = Sun,
        Sat
    }

    static void Main()
    {
        Console.WriteLine((int)Day.Wed);
        Console.WriteLine((int)Day.Fri);
        Console.WriteLine((int)Day.Sat);

    }

}