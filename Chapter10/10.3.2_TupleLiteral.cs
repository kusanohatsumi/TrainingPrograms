namespace Chap10_3_2;

class TupleLiteral
{
    static void Main()
    {
        (string name, int age) GetMember()
        {
            var n = "Wings";
            var a = 18;
            return (n, a);
        }
        var m = GetMember();
        Console.WriteLine(m.name);
        Console.WriteLine(m.age);
    }

}