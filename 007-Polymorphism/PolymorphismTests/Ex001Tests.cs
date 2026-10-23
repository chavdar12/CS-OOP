using Ex001;

namespace PolymorphismTests;

public class Ex001Tests
{
    [Test]
    public void AddOverloads()
    {
        Assert.That(MathOperations.Add(2, 3), Is.EqualTo(5));
        Assert.That(MathOperations.Add(2.5, 3.5, 4.0), Is.EqualTo(10.0));
        Assert.That(MathOperations.Add(2.2m, 3.3m, 4.4m), Is.EqualTo(9.9m));
    }

    [Test]
    public void ProgramPrintsSums()
    {
        Assert.That(ConsoleRunner.Run(typeof(MathOperations).Assembly), Is.EqualTo("5\n11\n9.9"));
    }
}
