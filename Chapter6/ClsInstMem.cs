namespace Chap6_ClsInstMem;

    class Car
    {
        
        public string name = "マイカー"; 
        public int seats;
    }

class ClsInstMem
{
    static void Main()
    {
        var test = new Car();
        var test2 = new Car();

        test2.name = "サブ";     

        Console.WriteLine(test.name);  
        Console.WriteLine(test2.name); 
    }
}
