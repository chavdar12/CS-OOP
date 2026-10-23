using Ex002;

namespace EncapsulationTests;

public class Ex002Tests
{
    [TestCase(29, "2420.00")]
    [TestCase(30, "2640.00")]
    [TestCase(65, "2640.00")]
    public void UnderThirtyGetHalfTheIncrease(int age, string expectedSalary)
    {
        var person = new Person("Asen", "Ivanov", age, 2200);

        person.IncreaseSalary(20);

        Assert.That(person.ToString(), Is.EqualTo($"Asen Ivanov receives {expectedSalary} leva."));
    }

    [Test]
    public void ProgramIncreasesEverySalary()
    {
        var output = ConsoleRunner.Run(typeof(Person).Assembly, "2\nAsen Ivanov 65 2200\nBoiko Borisov 20 1000\n10\n");

        Assert.That(output, Is.EqualTo("Asen Ivanov receives 2420.00 leva.\nBoiko Borisov receives 1050.00 leva."));
    }
}
