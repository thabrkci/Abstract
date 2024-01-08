// Derived class representing a login user, inheriting from the Login abstract class
public class Loginuser : Login
{
    public override void Logincode()
    {
        Console.WriteLine($"Please Enter your Login code");
        string? logincode = Console.ReadLine();
        // You can process or store the login code as needed
    }

    public override void Name()
    {
        Console.WriteLine($"Please Enter your name");
        string? name = Console.ReadLine();
        // You can process or store the name as needed
    }

    public override void Password()
    {
        Console.WriteLine($"Please Enter your password");
        string? password = Console.ReadLine();
        // You can process or store the password as needed
    }

    public override void Surname()
    {
        Console.WriteLine($"Please Enter your surname");
        string? surname = Console.ReadLine();
        // You can process or store the surname as needed
    }
}