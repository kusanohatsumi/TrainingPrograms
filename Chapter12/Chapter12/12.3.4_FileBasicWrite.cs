namespace Chap12_3_4;

class FileBaseicWrite
{
    static void Main()
    {
        void Write(string name)
        {
            using StreamWriter sw = new(name, false, System.Text.Encoding.Default);

            sw.WriteLine("サンプル1");
            sw.WriteLine("サンプル2");
            sw.WriteLine("サンプル3");
        }
        void Read(string name)
        {
            using StreamReader sr = new(name, System.Text.Encoding.Default);

            string? line = default;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        try
        {
            string name = "sample.txt";
            Write(name);
            Read(name);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}