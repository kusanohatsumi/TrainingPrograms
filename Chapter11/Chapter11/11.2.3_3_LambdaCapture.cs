namespace Chap11_2_3_3;

class LambdaCapture
{
    public void Main()
    {
        Action CreateLambda(int n)
        {
            {
                int b = 2;
                return () =>
                {
                    Console.WriteLine(n * b);
                    b++;
                };
            }
        }
        Action action = CreateLambda(3);

        action();
        action();
    }

   }