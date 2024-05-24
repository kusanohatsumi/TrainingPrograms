partial class SampleEx
{
    public partial DateTime DateInfo();
}
class ClsPartialMethodImpEx
{
    static void Main()
    {
        Console.WriteLine(new SampleEx().DateInfo());
    }
}