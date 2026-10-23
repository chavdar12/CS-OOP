using Ex003;

namespace ExercisePolymorphismTests;

public class Ex003Tests
{
    [Test]
    public void HeroPowers()
    {
        Assert.That(new Druid("a").Power, Is.EqualTo(80));
        Assert.That(new Paladin("a").Power, Is.EqualTo(100));
        Assert.That(new Rogue("a").Power, Is.EqualTo(80));
        Assert.That(new Warrior("a").Power, Is.EqualTo(100));
    }

    [Test]
    public void ProgramWinsWhenPowerIsEnough()
    {
        var output = ConsoleRunner.Run(typeof(BaseHero).Assembly, "3\nMike\nPaladin\nJosh\nDruid\nScott\nWarrior\n250\n");

        Assert.That(output, Is.EqualTo(
            "Paladin - Mike healed for 100\nDruid - Josh healed for 80\nWarrior - Scott hit for 100 damage\nVictory!"));
    }

    [Test]
    public void ProgramRejectsInvalidHeroesAndLoses()
    {
        var output = ConsoleRunner.Run(typeof(BaseHero).Assembly, "1\nAl\nMage\nBo\nRogue\n100\n");

        Assert.That(output, Is.EqualTo("Invalid hero!\nRogue - Bo hit for 80 damage\nDefeat..."));
    }
}
