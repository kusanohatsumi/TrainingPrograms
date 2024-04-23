namespace Chap11_8_2;

public class Member
{
    public int No { get; }
    public string? Name { get; }

    public Member(int n, string s)
    {
        this.No = n;
        this.Name = s;
    }

    public void Deconstruct(out int No, out string? Name)
    {
        No = this.No;
        Name = this.Name;
        
    }

    public static void Main()
    {
        var m = new Member(2, "shota");

        var (no1, name1) = m;                 
        Console.WriteLine($"{no1},{name1}"); 

        if (m is Member(2, var name))         
        {
            Console.WriteLine(name);          
        }


        int select(Member? m)
        {
            return m switch
            {
                (1, "keita") => 0,                  
                { No: 6, Name: "kazuki" } => m.No,  
                (var x, _) when x > 0 => x,
                { } => -2,                          
                                                    
                _ => -1
            };
        }
        Console.WriteLine(select(m));                       
        Console.WriteLine(select(new Member(1, "keita")));  
        Console.WriteLine(select(new Member(6, "kazuki"))); 
        Console.WriteLine(select(new Member(-1, null)));    
        Console.WriteLine(select(null));


        int select2(int n, string m)
        {
            return (n, m) switch
            {
                (1, "keita") => 0,              
                { } => -1
            };
        }
        Console.WriteLine(select2(1, "keita"));

        int select3(int n, string m)
        {
            switch (n, m)
            {
                case (1, "keita"): return 0;
                default: return -1;
            }
        }
        Console.WriteLine(select3(1, "keita"));   



    }


}
