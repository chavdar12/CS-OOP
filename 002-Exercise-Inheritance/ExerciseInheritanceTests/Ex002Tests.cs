using Ex002;

namespace ExerciseInheritanceTests;

public class Ex002Tests
{
    [Test]
    public void MammalsAndReptilesAreAnimals()
    {
        Assert.That(new Bear("Baloo"), Is.InstanceOf<Mammal>());
        Assert.That(new Gorilla("Harambe"), Is.InstanceOf<Mammal>());
        Assert.That(new Lizard("Rex"), Is.InstanceOf<Reptile>());
        Assert.That(new Snake("Kaa"), Is.InstanceOf<Reptile>().And.InstanceOf<Animal>());
    }
}
