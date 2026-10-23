using Ex002;

namespace InheritanceTests;

public class Ex002Tests
{
    [Test]
    public void PuppyIsDogAndAnimal()
    {
        var puppy = new Puppy();

        Assert.That(puppy, Is.InstanceOf<Dog>());
        Assert.That(puppy, Is.InstanceOf<Ex001.Animal>());
    }

    [Test]
    public void ProgramEatsBarksAndWeeps()
    {
        Assert.That(ConsoleRunner.Run(typeof(Puppy).Assembly), Is.EqualTo("eating...\nbarking...\nweeping..."));
    }
}
