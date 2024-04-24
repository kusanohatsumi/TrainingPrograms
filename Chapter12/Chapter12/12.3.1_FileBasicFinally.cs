namespace Chap12_3_1;

class FileBasicFinally
{
    static void Main()
    {
        StreamReader? sr = null;

        try
        {
            sr = new("sample.txt", System.Text.Encoding.Default);

            string text = sr.ReadToEnd();

            Console.WriteLine(text);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            sr?.Close();
        }
    }
}