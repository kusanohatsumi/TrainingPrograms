namespace Chap11_4_5;

class ThreadPallalel
{
    static public void ThreadMethod()
    {
        Thread.Sleep(3000);
        Console.WriteLine("finish");
    }

    public static void Main()
    {
        Console.WriteLine("start");

        Parallel.Invoke(new Action(ThreadMethod),
        () =>
        {
            Thread.Sleep(5000);
            Console.WriteLine("finish");
        });
    }

}