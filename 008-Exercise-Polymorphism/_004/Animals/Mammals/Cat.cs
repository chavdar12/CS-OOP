using _004.Food;

namespace _004.Animals.Mammals;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }

    public override void Eat(Food.Food food)
    {
        if (food.GetType().Name is nameof(Vegetable) or nameof(Meat))
        {
            var gainWeight = food.Quantity * 0.30;
            Weight += gainWeight;
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}