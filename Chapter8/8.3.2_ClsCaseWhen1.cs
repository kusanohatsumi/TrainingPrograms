
class ClsCaseWhen1
{
static void Main()
{
    object obj = "visual";

    switch (obj)
    {
        case int n:
            Console.WriteLine(n);
            break;

        case string str when str.Length > 3:
            Console.WriteLine(str);
            break;
    }
}

}