class ClsCastDown
{
    static void Main()
    {
        Music m = new Song();

        Song s = m as Song;
        Music2 m2 = m as Music2;

        Console.WriteLine(s == null);
        Console.WriteLine(m2 == null);
    }
}