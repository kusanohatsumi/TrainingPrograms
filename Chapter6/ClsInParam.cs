namespace Chap6_ClsInParam;

class ClsInParam
{
    public static void Main()
    {
        void TestMethod(in int num, out string s)
        {
            
            

            if (num == 46)
            {
                s = "keyaki";
            }
            else
            {
                s = "abc";
            }
        }

        var n = 46;
        var str = "none";

        TestMethod(n, out str); 

        Console.WriteLine(str); 
    }
}
