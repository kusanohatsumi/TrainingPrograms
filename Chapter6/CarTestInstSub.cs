namespace Chap6_CarTest;

class CarTestInstSub
{
    static void Main()
    {
        Car mycar1 = new Car();
        Car mycar2 = new Car();
        Car mycar3 = mycar2;

        mycar3.name = "サブカー"; 

        Console.WriteLine(mycar3.name);      
        Console.WriteLine(mycar2.name);      

        
        Console.WriteLine(mycar2 == mycar3); 
    }
}

