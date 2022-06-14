namespace _003;

public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    private double Height { get; set; }
    private double Width { get; set; }

    public override double CalculatePerimeter()
    {
        return (Height + Width) * 2;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override string Draw()
    {
        return base.Draw() + GetType().Name;
    }
}