namespace Chap11_7_2;

static class ExtendTestClass
{
    public static void CheckJ(this TestClass t)
    {
        if (25 <= t.BMI())
        {
            Console.WriteLine("肥満です");
        }
        else if(t.BMI() < 18)
        {
            Console.WriteLine("やせすぎです");
        }
        else
        {
            Console.WriteLine("標準です");
        }
    }
}


class TestClass
{
    public double Weight { get; }

    public double Height { get; set; }

    public TestClass(double w, double h)
    {
        this.Weight = w;
        this.Height = h/100;
    }

    public double BMI()
    {
        return this.Weight / (this.Height * this.Height);
    }
}

class ExtendBMI
{
    public static void Main()
    {
        var a = new TestClass(80, 170);
        a.CheckJ();

        var b = new TestClass(40, 160);
        b.CheckJ();
    }
}