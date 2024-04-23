
namespace Chap11_2_6;

public class SampleLamda
{
    private int num;
    private string[] str_nums = new string[5];

    public string Name => "nothing";

    public string this[int key]
    {
        get => str_nums[key];
        set => str_nums[key] = value;
    }

    public SampleLamda() => num = 3;

    public int Multi(int a) => a * num;
}

class LambdaMember
{
    static void Main()
    {
        var c = new SampleLamda();

        Console.WriteLine(c.Name);
        Console.WriteLine(c.Multi(5));

        c[1] = "test";
        Console.WriteLine(c[1]);
    }
}