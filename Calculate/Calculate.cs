// Class derived from the home class representing a rectangle
public class Rectangle : AbstractHome
{
    // Properties for length and width of the rectangle
    public double Length { get; set; }
    public double Width { get; set; }

    // Implementation of the abstract method to calculate the area
    public override double CalculateArea()
    {
        return Length * Width;
    }
}