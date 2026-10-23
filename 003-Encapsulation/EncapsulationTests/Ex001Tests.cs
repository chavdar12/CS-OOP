using Ex001;

namespace EncapsulationTests;

public class Ex001Tests
{
    [Test]
    public void ToStringDescribesPerson()
    {
        Assert.That(new Person("Asen", "Ivanov", 65).ToString(), Is.EqualTo("Asen Ivanov is 65 years old."));
    }

    [Test]
    public void ProgramSortsByFirstNameThenAge()
    {
        var output = ConsoleRunner.Run(typeof(Person).Assembly,
            "3\nBoiko Borisov 57\nAsen Ivanov 65\nAsen Harizanoov 44\n");

        Assert.That(output, Is.EqualTo(
            "Asen Harizanoov is 44 years old.\nAsen Ivanov is 65 years old.\nBoiko Borisov is 57 years old."));
    }
}
