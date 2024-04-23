namespace Chap11_4_2;


class ThreadOld
{
    static public void ThreadMethod()
    {
        Thread.Sleep(3000);
        Console.WriteLine("finish");
    }


    public static void Main()
    {
        Console.WriteLine("start");

        var t = new Thread(new ThreadStart(ThreadMethod));
        t.Start();
        t.Join();
    }
}