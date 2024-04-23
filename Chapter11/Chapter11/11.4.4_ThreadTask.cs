namespace Chap11_4_4;


class ThreadTask
{
    static public void ThreadMethod()
    {
        Thread.Sleep(3000);
        Console.WriteLine("finish");
    }

    public static void Main()
    {
        Console.WriteLine("start");

        var task = Task.Run(new Action(ThreadMethod));

        task.Wait();
    }
}