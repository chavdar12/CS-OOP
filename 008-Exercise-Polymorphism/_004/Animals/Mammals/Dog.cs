using _004.Food;

namespace _004.Animals.Mammals;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }

    public override void Eat(Food.Food food)
    {
        if (food.GetType().Name == nameof(Meat))
        {
            var gainWeight = food.Quantity * 0.40;
            Weight += gainWeight;
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}