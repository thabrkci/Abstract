// Abstract base class representing the login functionality
public abstract class Login
{
    // Abstract methods to be implemented by derived classes
    public abstract void Name();
    public abstract void Surname();
    public abstract void Password();
    public abstract void Logincode();

    // Common method to display a message
    public void Showmessage()
    {
        Console.WriteLine("Please fill in the required information ");
    }
}