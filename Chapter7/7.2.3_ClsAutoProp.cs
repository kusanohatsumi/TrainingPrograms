namespace Chap7_ClsAutoProp;

class SampleClass
{
    public int Type { get; set; }
}

class ClsAutoProp
{
    static void Main()
    {
        var test = new SampleClass();

        test.Type = 1;
        Console.WriteLine(test.Type); 
    }
}

