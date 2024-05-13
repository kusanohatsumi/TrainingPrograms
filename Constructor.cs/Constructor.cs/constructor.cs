namespace Constructor;

class Person
{
    public string firstName;
    public string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string Show()
    {
        return $"私の名前は{this.lastName}{this.firstName}です。";
    }
}

 class Baisic
{
    static void Main()
    {
        var p = new Person("太郎", "山田");
        Console.WriteLine(p.Show());
    }
}