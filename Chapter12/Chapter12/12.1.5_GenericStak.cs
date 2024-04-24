namespace Chap12_1_5;

class GenericStac
{
    static void Main()
    {
        var st = new Stack<int>();

        st.Push(10);
        st.Push(11);
        st.Push(12);
        st.Push(13);

        Console.WriteLine(st.Pop());
        Console.WriteLine(st.Pop());

        Console.WriteLine(st.Peek());

        Console.WriteLine(st.Pop());

        st.Clear();

        st.Push(1);
        st.Push(2);
        st.Push(3);

        foreach (var i in st)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(st.Pop());
    }
}