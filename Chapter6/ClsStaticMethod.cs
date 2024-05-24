namespace Chap6_ClsStaticMethod;


class Car
{
    public string name;      
    public static int seats;  

    public Car()
    {
        name = "マイカー";
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

class ClsStaticMethod
{
    static void Main()
    {
        Car.SetSeat(5); 

        var test = new Car();
        test.Display();  

        var test2 = new Car();
        test2.Display(); 
    }
}
