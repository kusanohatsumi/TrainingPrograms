using System.Collections;

namespace Chap12_1_8;


public class MyReverserClass : IComparer
{
    int IComparer.Compare(Object? x, Object y)
    {
        return((new CaseInsensitiveComparer())).Compare(y, x);
    }
}
class GenericSorted
{
    public static void Main()
    {
        var myList = new SortedList(new MyReverserClass())
        {
            { "1st", "Tigers"},
            { "2nd", "Giants" },
            { "3rd", "Dragons" }
        };
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("[{0}] {1}", myList.GetKey(i),
                myList.GetByIndex(i));
        }
    }
}