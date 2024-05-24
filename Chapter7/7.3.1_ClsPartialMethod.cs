namespace Chap7_ClsPartialMethod;

partial class Sample
{
    static partial void LogInfo();

    static void Main()
    {
        LogInfo();

        Console.WriteLine("Hello");
    }

    static partial void LogInfo()
    {
        Console.WriteLine("debug");
    }

}
