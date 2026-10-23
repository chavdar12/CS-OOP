using Ex003;

namespace EncapsulationTests;

public class Ex003Tests
{
    [TestCase("As", "Ivanov", 20, 1000, "First name cannot contain fewer than 3 symbols!")]
    [TestCase("Asen", "Iv", 20, 1000, "Last name cannot contain fewer than 3 symbols!")]
    [TestCase("Asen", "Ivanov", 0, 1000, "Age cannot be zero or a negative integer!")]
    [TestCase("Asen", "Ivanov", 20, 649.99, "Salary cannot be less than 650 leva!")]
    public void InvalidDataThrows(string first, string last, int age, decimal salary, string message)
    {
        var error = Assert.Throws<ArgumentException>(() => new Person(first, last, age, salary));
        Assert.That(error.Message, Is.EqualTo(message));
    }

    [Test]
    public void ProgramReportsInvalidPeopleAndSkipsThem()
    {
        var output = ConsoleRunner.Run(typeof(Person).Assembly, "2\nAsen Ivanov -6 2200\nBoiko Borisov 57 3333\n20\n");

        Assert.That(output, Is.EqualTo("Age cannot be zero or a negative integer!\nBoiko Borisov receives 3999.60 leva."));
    }
}
