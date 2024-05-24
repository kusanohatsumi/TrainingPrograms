namespace Chap8_ClsInterface;

interface IGetInfo
{
    void GetInfo();
}

class SampleClass : IGetInfo
{
    public void GetInfo()
    {
        Console.WriteLine("SampleClass");
    }
}

class ClsInterface1
{
    static void Main()
    {
        var s = new SampleClass();
        s.GetInfo();                     
    }
}
