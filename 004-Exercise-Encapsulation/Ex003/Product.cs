namespace Ex003;

public class Product
{
    private readonly decimal cost;
    private readonly string name;

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }

    public string Name
    {
        get => name;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public decimal Cost
    {
        get => cost;
        private init
        {
            if (value < 0) throw new ArgumentException("Money cannot be negative");
            cost = value;
        }
    }
}