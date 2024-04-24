namespace Chap12_1_13;
using System.Collections;

class GenericWhere
{
    static void Main()
    {
        void ListPrint<T>(in T col) where T : IEnumerable
        {
            foreach (var v in col)
            {
                Console.Write(v);
            }
        }

        var list = new List<string>() { "Hello", "World", "Good-Bye" };
        ListPrint(list);
    }

}