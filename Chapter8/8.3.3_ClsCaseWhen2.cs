
class ClsCaseWhen2
{
    static void Main()
    {
        string testString<T>(T prm)
        {
            switch (prm)
            {
                case string tmp:
                    return tmp;

                default:
                    return "Number";
            }
        }
        Console.WriteLine(testString(123));
        Console.WriteLine(testString("123"));

    }
}