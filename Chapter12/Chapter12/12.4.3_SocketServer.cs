using System.Net;
using System.Net.Sockets;

namespace Chap12_4_3;

class SocketServer
{
    static void Main()
    {
        TcpListener listener = new(IPAddress.Any, 3000);
        Console.WriteLine("①接続を準備しています");

        listener.Start();
        Console.WriteLine("接続を待機しています。");

        while (true)
        {
            using (var client = listener.AcceptTcpClient())
            {
                Console.WriteLine("③接続しました");

                using var ns = client.GetStream();

                byte[] rb = new byte[3];
                ns.Read(rb, 0, rb.Length);
                Console.WriteLine($"④受信　←　{BitConverter.ToString(rb)}");

                byte[] sb = {3, 4, 5};
                ns.Read(sb, 0, sb.Length);
                Console.WriteLine($"④送信　→　{BitConverter.ToString(sb)}");
            }
            Console.WriteLine("⑤切断しました");
        }
    }
}