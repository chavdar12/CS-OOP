using Ex006;

namespace ReflectionAndAttributesTests;

public class Ex006Tests
{
    [Test]
    public void ProgramPrintsMethodAuthors()
    {
        Assert.That(ConsoleRunner.Run(typeof(Tracker).Assembly), Is.EqualTo("Main is written by DartVayder"));
    }
}
