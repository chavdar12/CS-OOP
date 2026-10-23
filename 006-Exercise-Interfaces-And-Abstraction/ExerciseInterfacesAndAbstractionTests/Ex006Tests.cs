using Ex006;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex006Tests
{
    [Test]
    public void CitizensBuyTenAndRebelsBuyFive()
    {
        var citizen = new Citizen("Peter", 25, "1", "01/01/2000");
        var rebel = new Rebel("Stan", 27, "WildMonkeys");

        citizen.BuyFood();
        rebel.BuyFood();

        Assert.That(citizen.Food, Is.EqualTo(10));
        Assert.That(rebel.Food, Is.EqualTo(5));
    }

    [Test]
    public void ProgramSumsFoodBought()
    {
        var output = ConsoleRunner.Run(typeof(Rebel).Assembly,
            "2\nPeter 25 8904041303 04/04/1989\nStan 27 WildMonkeys\nPeter\nGeorge\nPeter\nStan\nEnd\n");

        Assert.That(output, Is.EqualTo("25"));
    }
}
