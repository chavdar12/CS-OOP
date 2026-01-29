namespace Ex002;

public class Animal
{
    protected Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }

    private string Name { get; }
    private string FavouriteFood { get; }

    public virtual string ExplainSelf()
    {
        return $"I am {Name} and my favorite food is {FavouriteFood}";
    }
}