using Ex003;

namespace InheritanceTests;

public class Ex003Tests
{
    [Test]
    public void DogAndCatAreAnimals()
    {
        Assert.That(new Dog(), Is.InstanceOf<Animal>());
        Assert.That(new Cat(), Is.InstanceOf<Animal>());
    }

    [Test]
    public void ProgramRunsBothAnimals()
    {
        Assert.That(ConsoleRunner.Run(typeof(Cat).Assembly),
            Is.EqualTo("eating...\nbarking...\neating...\nmeowing..."));
    }
}
