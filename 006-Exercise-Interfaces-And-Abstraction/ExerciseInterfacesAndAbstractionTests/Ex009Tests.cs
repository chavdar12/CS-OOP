using Ex009;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex009Tests
{
    [Test]
    public void ProgramUsesExplicitInterfaceImplementation()
    {
        Assert.That(ConsoleRunner.Run(typeof(Citizen).Assembly, "Peter Bulgaria 25\nEnd\n"),
            Is.EqualTo("Peter\nMr/Ms/Mrs Peter"));
    }
}
