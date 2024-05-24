namespace Chap10_1_4;

class ArrayLoopMult
{
    static void Main()
    {
        string[,] array = { { "一", "二" }, { "三", "四" }, { "五", "六" } };

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "");
            }
            Console.WriteLine("");
        }
    }
}