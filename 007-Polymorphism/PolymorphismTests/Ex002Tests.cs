using Ex002;

namespace PolymorphismTests;

public class Ex002Tests
{
    [Test]
    public void ProgramExplainsEachAnimal()
    {
        Assert.That(ConsoleRunner.Run(typeof(Animal).Assembly), Is.EqualTo(
            "I am Peter and my favorite food is Whiskas\nMEEOW\nI am George and my favorite food is Meat\nDJAAF"));
    }
}
