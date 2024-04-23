namespace Chap11_4_6;


class TreadAwait
{
    public static async Task ThreadMethodAsync()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(3000);
            Console.WriteLine("finish");
        });
    }

    public static void Main()
    {
        Console.WriteLine("start");
        var t = ThreadMethodAsync();
        t.Wait();
    }
}