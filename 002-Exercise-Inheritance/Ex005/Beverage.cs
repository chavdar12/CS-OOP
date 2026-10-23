namespace Ex005;

public class Beverage : Product
{
    protected Beverage(string name, decimal price, double milliliters) : base(name, price)
    {
        Milliliters = milliliters;
    }

    public double Milliliters { get; }
}