namespace Chap12_4_6;

class HttpSimple
{
    static readonly HttpClient Client = new();

    static void Main()
    {
        async Task GetWebLengthAsync(string url)
        {
            var c = await Client.GetStringAsync(url);

            Console.WriteLine($"{url} : {c.Length}");

        }
        GetWebLengthAsync("http://www.yahoo.co.jp/").Wait();
        GetWebLengthAsync("http://www.msn.com/").Wait();
    }
}
