using Ex004;

namespace ExerciseEncapsulationTests;

public class Ex004Tests
{
    [Test]
    public void CaloriesCombineDoughAndToppings()
    {
        var pizza = new Pizza("Meaty", new Dough("White", "Chewy", 100));
        pizza.AddTopping(new Topping("Meat", 30));

        Assert.That(pizza.CalculateTotalCalories(), Is.EqualTo(330 + 72).Within(1e-9));
    }

    [Test]
    public void InvalidIngredientsThrow()
    {
        Assert.That(Assert.Throws<ArgumentException>(() => new Dough("Tip500", "Chewy", 100)).Message,
            Is.EqualTo("Invalid type of dough."));
        Assert.That(Assert.Throws<ArgumentException>(() => new Dough("White", "Chewy", 201)).Message,
            Is.EqualTo("Dough weight should be in the range [1..200]."));
        Assert.That(Assert.Throws<ArgumentException>(() => new Topping("Sushi", 10)).Message,
            Is.EqualTo("Cannot place Sushi on top of your pizza."));
        Assert.That(Assert.Throws<ArgumentException>(() => new Topping("Meat", 51)).Message,
            Is.EqualTo("Meat weight should be in the range [1..50]."));
        Assert.Throws<ArgumentException>(() => new Pizza("", new Dough("White", "Chewy", 100)));
    }

    [Test]
    public void MoreThanTenToppingsThrows()
    {
        var pizza = new Pizza("Loaded", new Dough("White", "Chewy", 100));
        for (var i = 0; i < 10; i++) pizza.AddTopping(new Topping("Cheese", 1));

        Assert.Throws<InvalidOperationException>(() => pizza.AddTopping(new Topping("Cheese", 1)));
    }

    [Test]
    public void ProgramPrintsTotalCalories()
    {
        var output = ConsoleRunner.Run(typeof(Pizza).Assembly,
            "Pizza Meatless\nDough Wholegrain Crispy 100\nTopping Veggies 50\nTopping Cheese 50\nEND\n");

        Assert.That(output, Is.EqualTo("Meatless - 370.00 Calories."));
    }
}
