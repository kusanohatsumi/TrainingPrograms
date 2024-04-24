namespace Chap12_1_4;

class GenericLinkedList
{
    static void Main()
    {
        var list = new LinkedList<string>();

        list.AddFirst("First");

        list.AddFirst("Last");

        for (int i = 0; i < 3; i++)
        {
            list.AddAfter(list.First!, i.ToString());
        }

        foreach (var s in list)
        {
            Console.WriteLine(s);
        }
    }
}