namespace Chap12_1_10;


class AsyncStream
{
    static async Task Main()
    {
        async IAsyncEnumerable<int> factorial(int number)
        {
            for (int i = number; 0 < i; i--)
            {
                await Task.Delay(100);
                yield return i;
            }

        }
        await foreach (var d in factorial(50)){
            Console.WriteLine(d);
        }
        Console.ReadLine();
    }

}

