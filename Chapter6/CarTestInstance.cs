namespace Chap6_CarTest;

class CarTestInstance
{
    static void Main()
    {
        Car mycar1 = new Car();
        Car mycar2 = new Car();

        
        Console.WriteLine(mycar1 == mycar2); 

        mycar1.name = "メイン";
        mycar2.name = "サブ";

        Console.WriteLine(mycar1.name);
        Console.WriteLine(mycar2.name);
    }
}
