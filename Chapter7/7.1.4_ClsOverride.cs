
namespace Chap7_ClsOverride
{
    class Music
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    class Song : Music
    {
        public override void BaseInfo()
        {
            Console.WriteLine("Song");
        }
    }

    class Music2 : Music
    {
        new public void BaseInfo() 
        {
            Console.WriteLine("Music2");
        }
    }

    class ClsOverride
    {
        static void Main()
        {
            var s = new Song();
            s.BaseInfo();              

            var m2 = new Music2();
            m2.BaseInfo();             

            var m = new Music();
            m.BaseInfo();              
        }
    }
}