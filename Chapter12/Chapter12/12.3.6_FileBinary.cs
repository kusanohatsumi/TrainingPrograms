namespace Chap12_3_6;

class FileBinary
{
    static void Main()
    {
        try
        {
            var bytes = File.ReadAllBytes("sample.png");

            Console.WriteLine(BitConverter.ToString(bytes, 0, 10));

            byte[] bytes2 = { 0x1, 0x2, 0x3 };

            File.WriteAllBytes("test.dat", bytes2);
            Console.WriteLine(BitConverter.ToString(File.ReadAllBytes("test.dat")));
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}