namespace _005;

public class Product
{
    protected Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    private string Name { get; set; }
    private decimal Price { get; set; }
}