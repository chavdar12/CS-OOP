namespace _004;

public class Topping
{
    private Dictionary<string, double> toppingTypes = new()
    {
        {"meat", 1.2},
        {"veggies", 0.8},
        {"cheese", 1.1},
        {"sauce", 0.9}
    };

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    private string Type
    {
        get => type;
        init
        {
            if (!toppingTypes.ContainsKey(value.ToLower()))
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            type = value;
        }
    }

    private double Weight
    {
        get => weight;
        init
        {
            if (value is < 1 or > 50) throw new ArgumentException($"{Type} weight should be in the range [1..50].");
            weight = value;
        }
    }

    public double Calories
        => 2 * Weight * toppingTypes[Type.ToLower()];
}