namespace Chap12_3_1;

class FileBasicTry
{
    static void Main()
    {
        try
        {
            StreamReader sr = new("sample.txt", System.Text.Encoding.Default);

            string text = sr.ReadToEnd();

            sr.Close();

            Console.WriteLine(text);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}