namespace Chap11_4_3;


class ThreadPool
{
    static void Main()
    {
        void testThread(Object? stateInfo)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stateInfo + "" + i);
                Thread.Sleep(200);
            }
        }
        //ThreadPool.QueueUserWorkItem(new WaitCallback(testThread),"1");
        //ThreadPool.QueueUserWorkItem(new WaitCallback(testThread),"2");
        //ThreadPool.QueueUserWorkItem(new WaitCallback(testThread),"3");

        Console.ReadLine();
    }


}
