namespace Chap12_3_1;

class FileBase
{
    static void Main()
    {
        StreamReader sr = new("sample.txt", System.Text.Encoding.Default);

        string text = sr.ReadToEnd();

        sr.Close();

        Console.WriteLine(text);
    } 
}