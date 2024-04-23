namespace Chap11_2_7;

class LambdThrow
{
    static public int Throw1() => throw new Exception("Lambda");

    static public string Throw2(int ct)
    {
        return (ct < 0) ? throw new InvalidOperationException("nothing")
        : ct.ToString();
    }


    static void Main()
    {

        object? sample_var = null;
        var s = sample_var as string ?? throw new Exception();
    }
}