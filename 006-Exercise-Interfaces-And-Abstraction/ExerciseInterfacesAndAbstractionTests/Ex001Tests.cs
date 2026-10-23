using Ex001;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex001Tests
{
    [Test]
    public void ProgramPrintsNameAndAge()
    {
        Assert.That(ConsoleRunner.Run(typeof(IPerson).Assembly, "Peter\n25\n"), Is.EqualTo("Peter\n25"));
    }
}
