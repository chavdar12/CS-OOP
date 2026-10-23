using Ex001;

namespace ExerciseInheritanceTests;

public class Ex001Tests
{
    [Test]
    public void ChildIsPerson()
    {
        Assert.That(new Child("Tim", 5), Is.InstanceOf<Person>());
    }

    [Test]
    public void ToStringShowsNameAndAge()
    {
        Assert.That(new Person("Peter", 30).ToString(), Is.EqualTo("Name: Peter, Age: 30"));
    }

    [Test]
    public void ProgramPrintsPerson()
    {
        Assert.That(ConsoleRunner.Run(typeof(Person).Assembly, "Peter\n13\n"), Is.EqualTo("Name: Peter, Age: 13"));
    }

    [Test]
    public void ProgramIgnoresNegativeAge()
    {
        Assert.That(ConsoleRunner.Run(typeof(Person).Assembly, "Peter\n-1\n"), Is.Empty);
    }
}
