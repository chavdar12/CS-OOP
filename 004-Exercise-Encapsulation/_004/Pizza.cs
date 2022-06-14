namespace _004;

public class Pizza
{
    private string name;
    private List<Topping> toppings;

    public Pizza(string name, Dough dough)
    {
        Name = name;
        Dough = dough;
        toppings = new List<Topping>();
    }

    public string Name
    {
        get => name;
        private init
        {
            if (value.Length is < 1 or > 15)
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            name = value;
        }
    }

    private Dough Dough { get; set; }

    public IReadOnlyCollection<Topping> Toppings => toppings;

    public double CalculateTotalCalories()
    {
        var result = Dough.Calories + toppings.Sum(x => x.Calories);
        return result;
    }

    public void AddTopping(Topping topping)
    {
        if (toppings.Count == 10) throw new InvalidOperationException("Number of toppings should be in range [0..10].");
        toppings.Add(topping);
    }
}