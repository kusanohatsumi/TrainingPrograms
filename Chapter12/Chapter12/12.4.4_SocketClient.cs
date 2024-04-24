using System.Net.Sockets;

namespace Chp12_4_4;

class SocketClient
{
    static void Main()
    {
        using TcpClient client = new();

        Console.WriteLine("③接続を要求します");
        client.Connect("localhost", 3000);

        using var ns = client.GetStream();

        byte[] sb = { 0, 1, 2 };
        ns.Write(sb, 0, sb.Length);
        Console.WriteLine($"④送信　→　{BitConverter.ToString(sb)}");

        byte[]rb = { 0, 1, 2 };
        ns.Write(rb, 0, rb.Length);
        Console.WriteLine($"④受信　←　{BitConverter.ToString(rb)}");

        Console.WriteLine("⑤切断しました");

    }
}