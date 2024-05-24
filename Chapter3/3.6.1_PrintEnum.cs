namespace Chap3_6_1;

class PrintEnum

{
    enum Day
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat
    }

    static void Main()
    {
        Console.WriteLine(Day.Sun);
        Console.WriteLine((int)Day.Sat);
    }

}