namespace Chap12_3_3;

class FielBasicUsingC8
{
    static void Main()
    {
        try
        {
            using StreamReader sr = new("sample.txt", System.Text.Encoding.Default);

            string text = sr.ReadToEnd();
            Console.WriteLine(text);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}