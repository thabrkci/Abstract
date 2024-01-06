// Main application class
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Rectangle class
        Rectangle rectangle = new Rectangle();

        // Assigning values to the length and width properties
        rectangle.Length = 5;
        rectangle.Width = 3;

        // Calculating the area of the rectangle
        double area = rectangle.CalculateArea();

        // Printing the result to the console
        Console.WriteLine("Rectangle Area: " + area);

        // Attempting to create an instance of the abstract class directly (which is not allowed)
        // AbstractHome home = new AbstractHome(); // You will get an error
    }
}