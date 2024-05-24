using System;
namespace Chap7_ClsInitializers;

class SampleClass
{
    public int v1 = 10;
    private int v2;

    public SampleClass()
    {
        Console.WriteLine(this.v1);
    }

}

class ClsInitializers
{
    static void Main()
    {
        var test = new SampleClass { v1 = 20 }; 
        Console.WriteLine(test.v1);            

    }
}
