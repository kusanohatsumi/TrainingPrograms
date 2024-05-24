using System.Dynamic;

namespace Chap10_3_4;

class TupleDeconstruction
{
    static void Main()
    {
        (string name, int age) GetMember()
        {
            var n = "Wings";
            var a = 18;
            return (n, a);
        }

        (string name, int age) = GetMember();
        Console.WriteLine(name);
        Console.WriteLine(age);

        (var name1, var age1) = GetMember();
        (_, int age2) = GetMember();
    }
}