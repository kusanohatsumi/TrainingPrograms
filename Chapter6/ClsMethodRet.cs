namespace Chap6_ClsMethod;

class ClsMethodRet
{
    
    public int MyMethod1()
    {
        return 10;
    }

    
    public void MyMethod2(int a)
    {
        if (a < 3)
        {
            return;              
        }

        Console.WriteLine(a); 
    }
}
