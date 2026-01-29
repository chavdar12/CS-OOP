namespace Ex003;

public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    private double Height { get; }
    private double Width { get; }

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