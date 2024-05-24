//namespace Chap9_ExceptWhen2;

//class ExceptWhen2
//{
//    static void Main()
//    {
//        try
//        {
//            int z = x / y;
//        }
//        catch(Exception e) when (e is DivideByZeroException || e is ArithmeticException )
//        {
//            Console.WriteLine(e.Message);
//        }
//    }
//}