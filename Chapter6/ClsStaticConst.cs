namespace Chap6_ClsStaticConst;

class Car
{
    public string name;       
    public static int seats; 
    public Car()
    {
        name = "マイカー";
        Console.WriteLine(name);
    }

    static Car()
    {
        seats = 4;
        Console.WriteLine(seats);
    }

    public static void SetSeat(int n)
    {
        seats = n; 
    }

    public void Display()
    {
        Console.WriteLine(seats); 
    }
}

class ClsStaticConst
{
    static void Main()
    {
        var test = new Car();  

        Car.SetSeat(5);        

        var test2 = new Car(); 

        test2.Display();       
    }
}
