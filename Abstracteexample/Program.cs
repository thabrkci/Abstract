class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Loginuser
        Loginuser loginuser = new();
        loginuser.Showmessage();
        loginuser.Name();
        loginuser.Surname();
        loginuser.Password();
        loginuser.Logincode();

        // Creating an instance of Sportpage
        Console.WriteLine("Sportpage");
        Sportpage sportpage = new();
        sportpage.Showmessage();
        sportpage.Name();
        sportpage.Surname();
        sportpage.Password();
        sportpage.Logincode();

        // Creating an instance of Newspage
        Console.WriteLine("Newspage");
        Newspage newspage = new();
        newspage.Showmessage();
        newspage.Name();
        newspage.Surname();
        newspage.Password();
        newspage.Logincode();

        Console.WriteLine("");
    }
}