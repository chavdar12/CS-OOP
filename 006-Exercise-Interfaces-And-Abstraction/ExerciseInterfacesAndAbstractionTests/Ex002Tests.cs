using Ex002;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex002Tests
{
    [Test]
    public void CitizenImplementsAllInterfaces()
    {
        Assert.That(new Citizen("Peter", 25, "1", "01/01/2000"),
            Is.InstanceOf<IPerson>().And.InstanceOf<IIdentifiable>().And.InstanceOf<IBirthable>());
    }

    [Test]
    public void ProgramPrintsIdAndBirthdate()
    {
        Assert.That(ConsoleRunner.Run(typeof(Citizen).Assembly, "Peter\n25\n9105152287\n15/05/1991\n"),
            Is.EqualTo("9105152287\n15/05/1991"));
    }
}
