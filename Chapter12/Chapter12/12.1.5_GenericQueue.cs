namespace Chap12_1_5;

class GenericQueue
{
    static void Main()
    {
        var q = new Queue<int>();

        q.Enqueue(10);
        q.Enqueue(11);
        q.Enqueue(12);
        q.Enqueue(13);

        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());

        Console.WriteLine(q.Peek());

        Console.WriteLine(q.Dequeue());

        q.Clear();

        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        foreach (var i in q)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(q.Dequeue());
    }
}