using Ex002;

namespace ExerciseEncapsulationTests;

public class Ex002Tests
{
    [TestCase(0, 1.5)]
    [TestCase(3, 1.5)]
    [TestCase(4, 2)]
    [TestCase(7, 2)]
    [TestCase(8, 1)]
    [TestCase(11, 1)]
    [TestCase(12, 0.75)]
    [TestCase(15, 0.75)]
    public void ProductPerDayDependsOnAge(int age, double eggs)
    {
        Assert.That(new Chicken("Kokoshka", age).ProductPerDay, Is.EqualTo(eggs));
    }

    [Test]
    public void InvalidAgeOrNameThrows()
    {
        Assert.That(Assert.Throws<ArgumentException>(() => new Chicken("Kokoshka", 16)).Message,
            Is.EqualTo("Age should be between 0 and 15."));
        Assert.That(Assert.Throws<ArgumentException>(() => new Chicken(" ", 1)).Message,
            Is.EqualTo("Name cannot be empty."));
    }

    [Test]
    public void ProgramPrintsEggs()
    {
        Assert.That(ConsoleRunner.Run(typeof(Chicken).Assembly, "Kokoshka\n10\n"),
            Is.EqualTo("Chicken Kokoshka (age 10) can produce 1 eggs per day."));
    }
}
