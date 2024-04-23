namespace Space1
{
    class Class1
    {
        public static void OutPut()
        {
            Console.WriteLine("Space1.Class1");
        }
    }
}

namespace Space2
{
    class Class2
    {
        public static void Output()
        {
            Console.WriteLine("Space2.Class2");
        }
    }
}

namespace Space1
{
    class Class3
    {
        public static void Output()
        {
            Console.WriteLine("Space1.Class3");
        }
    }
}

namespace SampleSpace
{
    class Class1
    {
        public static void Main()
        {
            Space1.Class1.OutPut();
            Space2.Class2.Output();
            Space1.Class3.Output();
        }
    }
}

