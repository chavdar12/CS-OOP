using Ex005;

namespace ExerciseInheritanceTests;

public class Ex005Tests
{
    [Test]
    public void CoffeeHasFixedSizeAndPrice()
    {
        var coffee = new Coffee("Espresso", 30);

        Assert.That(coffee.Name, Is.EqualTo("Espresso"));
        Assert.That(coffee.Price, Is.EqualTo(3.50m));
        Assert.That(coffee.Milliliters, Is.EqualTo(50));
        Assert.That(coffee.Caffeine, Is.EqualTo(30));
    }

    [Test]
    public void CakeHasFixedGramsCaloriesAndPrice()
    {
        var cake = new Cake("Tiramisu");

        Assert.That(cake.Grams, Is.EqualTo(250));
        Assert.That(cake.Calories, Is.EqualTo(1000));
        Assert.That(cake.Price, Is.EqualTo(5m));
    }

    [Test]
    public void FishHasFixedGrams()
    {
        Assert.That(new Fish("Salmon", 12m).Grams, Is.EqualTo(22));
    }

    [Test]
    public void ProductHierarchy()
    {
        Assert.That(new Soup("Tarator", 2m, 300), Is.InstanceOf<Starter>().And.InstanceOf<Food>());
        Assert.That(new Tea("Green", 1m, 200, 10), Is.InstanceOf<HotBeverage>());
        Assert.That(new ColdBeverage("Cola", 2m, 330), Is.InstanceOf<Beverage>().And.InstanceOf<Product>());
    }
}
