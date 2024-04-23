namespace Chap11_3_1;

delegate void SampleEventHandler();

class TestClass
{
    public event SampleEventHandler ThreeEvent = delegate { };

    public void OnThreeEvent()
    {
        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine(i);
            if ( i % 3 == 0)
            {
                ThreeEvent();
            }
        }
    }
}


class EventInit
{
    public static void Main()
    {
        var t = new TestClass();

        t.ThreeEvent += () => Console.WriteLine("XX");

        t.OnThreeEvent();
    }
}