namespace Chap12_3_4;

class FileBasicLine
{
    static void Main()
    {
        try
        {
            using StreamReader sr = new("sample.txt", System.Text.Encoding.Default);

            string? line = default;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}