namespace _005;

public class Dessert : Food
{
    protected Dessert(string name, decimal price, double grams, double calories)
        : base(name, price, grams)
    {
        Calories = calories;
    }

    private double Calories { get; set; }
}