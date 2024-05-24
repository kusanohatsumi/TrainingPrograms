namespace Chap7_ClsMusicConstructor;

    class Music
    {
        public Music()                  
        {
            Console.WriteLine("基本クラスのコンストラクター");
        }
    }

    class Song : Music
    {
        public string Key = "C#";

        public Song()                  
        {
            Console.WriteLine("派生クラスのコンストラクター");
        }
    }

    class ClsConstructor
{
        static void Main()
        {
            var s = new Song();
        }
    }
