namespace Chap11_4_7;

class ThradResult
{
    public static async Task<long> ThreadMethodAsync()
    {
        long val = 0;
        return await Task.Run(() =>
        {
            for (long i = 1; i <= 1000000000; i++)
            {
                val += i;
            }
            return val;
        });
    }
    public static void Main()
    {
        Console.WriteLine("start");
        Task<long> t = ThreadMethodAsync();

        t.Wait();

        Console.WriteLine(t.Result);
    }
}
