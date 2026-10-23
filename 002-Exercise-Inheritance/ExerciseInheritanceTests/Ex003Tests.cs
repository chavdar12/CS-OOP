using Ex003;

namespace ExerciseInheritanceTests;

public class Ex003Tests
{
    [Test]
    public void ToStringShowsTypeNameAndLevel()
    {
        Assert.That(new MuseElf("Ivan", 5).ToString(), Is.EqualTo("Type: MuseElf Username: Ivan Level: 5"));
    }

    [Test]
    public void HeroHierarchy()
    {
        Assert.That(new MuseElf("a", 1), Is.InstanceOf<Elf>());
        Assert.That(new BladeKnight("a", 1), Is.InstanceOf<Knight>());
        Assert.That(new DarkKnight("a", 1), Is.InstanceOf<Knight>());
        Assert.That(new DarkWizard("a", 1), Is.InstanceOf<Wizard>());
        Assert.That(new SoulMaster("a", 1), Is.InstanceOf<Wizard>().And.InstanceOf<Hero>());
    }
}
