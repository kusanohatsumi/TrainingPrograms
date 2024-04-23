using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11_4_8;

class AwaitMain
{
    const string Url = "http://www.yahoo.co.jp/";
    static readonly HttpClient Client = new();

    static async Task Main()
    {
        var c = await Client.GetStringAsync(Url);
        Console.WriteLine($"{Url} : {c.Length}");
    }
}