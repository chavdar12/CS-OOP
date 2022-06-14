namespace _003;

public class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    private double Radius { get; set; }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string Draw()
    {
        return base.Draw() + GetType().Name;
    }
}