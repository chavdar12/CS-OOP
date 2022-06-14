namespace _005;

public class Coffee : HotBeverage
{
    private const double milliliters = 50;
    private const decimal price = 3.50M;

    public Coffee(string name, double caffeine)
        : base(name, price, milliliters)
    {
        Caffeine = caffeine;
    }

    private double Caffeine { get; set; }
}