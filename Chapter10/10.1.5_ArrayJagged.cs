namespace Chap10_1_5;

class ArrayJagged
{
    static void Main()
    {
        int[][,] a = new int[3][,];

        a[0] = new int[,] { { 10, 20 }, { 100, 200 } };
        a[1] = new int[,] { { 30, 40, 50 }, { 300, 400, 500 } };
        a[2] = new int[,] { { 60, 70, 80, 90 }, { 600, 700, 800, 900 } };

        Console.WriteLine(a[0][0, 0]);  
        Console.WriteLine(a[1][1, 1]); 
        Console.WriteLine(a[2][1, 3]); 

        Console.WriteLine(a.Length);   

        Console.WriteLine(a[0].Length);
        Console.WriteLine(a[1].Length);
        Console.WriteLine(a[2].Length);

        Console.WriteLine(a.Rank);      
        Console.WriteLine(a[0].Rank);  
    }
}

