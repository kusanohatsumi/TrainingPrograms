namespace Chap6_CarTest;

class Car
{
    
    public string name = "";
    public int seats = 4;
}
class CarTest
{
    static void Main()
    {
        Car mycar = new Car();            
        mycar.name = "マイカー";          
        Console.WriteLine(mycar.name);    
        Console.WriteLine(mycar.seats);
    }
}