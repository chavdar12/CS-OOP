using Ex004.Animals.Birds;
using Ex004.Animals.Mammals;
using Ex004.Food;

namespace ExercisePolymorphismTests;

public class Ex004Tests
{
    [Test]
    public void AnimalGainsWeightFromFoodItEats()
    {
        var cat = new Cat("Pesho", 1, "Home", "Persian");

        cat.Eat(new Meat(10));

        Assert.That(cat.ToString(), Is.EqualTo("Cat [Pesho, Persian, 4, Home, 10]"));
    }

    [Test]
    public void AnimalRejectsFoodItDoesNotEat()
    {
        var error = Assert.Throws<ArgumentException>(() => new Owl("Hedwig", 1, 30).Eat(new Seeds(1)));
        Assert.That(error.Message, Is.EqualTo("Owl does not eat Seeds!"));
    }

    [Test]
    public void ProgramFeedsTheFarm()
    {
        var output = ConsoleRunner.Run(typeof(Hen).Assembly,
            "Tiger Rex 167.7 Asia Bengal\nVegetable 1\nDog Tommy 500 Street\nMeat 4\nOwl Toncho 2.5 30\nMeat 1\n" +
            "Hen Ka 1 2\nSeeds 2\nMouse Jerry 0.5 Hole\nFruit 5\nEnd\n");

        Assert.That(output, Is.EqualTo(
            "ROAR!!!\nTiger does not eat Vegetable!\nWoof!\nHoot Hoot\nCluck\nSqueak\n" +
            "Tiger [Rex, Bengal, 167.7, Asia, 0]\nDog [Tommy, 501.6, Street, 4]\nOwl [Toncho, 30, 2.75, 1]\n" +
            "Hen [Ka, 2, 1.7, 2]\nMouse [Jerry, 1, Hole, 5]"));
    }
}
