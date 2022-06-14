namespace _005;

public class Food : Product
{
    protected Food(string name, decimal price, double grams)
        : base(name, price)
    {
        Grams = grams;
    }

    private double Grams { get; set; }
}