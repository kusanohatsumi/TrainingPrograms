namespace Chap6_ClsConstructor;

class Car
{
    
    public string name = "";
    public int seats;

    
    public Car()
    {
        seats = 4;
    }

    
    public Car(string str)
    {
        seats = 4;
        name = str;
    }

}

class ClsConstructor
{
    static void Main()
    {
        var test = new Car();
        Console.WriteLine(test.name);   

        var test2 = new Car("マイカー");
        Console.WriteLine(test2.name);  
    }
}