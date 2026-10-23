using Ex001;

namespace InheritanceTests;

public class Ex001Tests
{
    [Test]
    public void DogInheritsEatFromAnimal()
    {
        Assert.That(new Dog(), Is.InstanceOf<Animal>());
    }

    [Test]
    public void ProgramEatsThenBarks()
    {
        Assert.That(ConsoleRunner.Run(typeof(Dog).Assembly), Is.EqualTo("eating...\nbarking..."));
    }
}
