namespace _004.Animals;

public abstract class Animal
{
    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
        FoodEaten = 0;
    }

    public virtual string Name { get; set; }
    protected virtual double Weight { get; set; }
    protected virtual int FoodEaten { get; set; }

    public abstract string ProduceSound();
    public abstract void Eat(Food.Food food);
}