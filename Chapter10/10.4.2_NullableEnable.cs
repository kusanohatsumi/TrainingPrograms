namespace Chap10_4_2;

#nullable enable
class Simple
{
    public string Name { get; set; }
}

class NullableEnable
{
    static void Main()
    {
        string s1 = null;
        string s2 = default;
        string? str1 = null;
        var v = new Simple();
    }

}