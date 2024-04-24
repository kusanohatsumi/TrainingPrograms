namespace Chap12_3_2;

class FileBasicUsing
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new("sample.txt", System.Text.Encoding.Default))
            {
                string text = sr.ReadToEnd();

                Console.Write(text);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}