namespace Chap11_6_3;


class TestClass
{
    readonly string Str;
    readonly int Num;

    public TestClass(int num, string str)
    {
        this.Num = num;
        this.Str = str;
    }

    public void OutPut() => Console.WriteLine($"{this.Num} {this.Str}");

    public static TestClass operator +(TestClass a, TestClass b) => new(a.Num + b.Num, a.Str + b.Str);

    class OverloadIn
    {
        public static void Main()
        {
            var a = new TestClass(1, "演算子");
            a += new TestClass(2, "オーバーロード");

            a.OutPut();

        }
    }

}