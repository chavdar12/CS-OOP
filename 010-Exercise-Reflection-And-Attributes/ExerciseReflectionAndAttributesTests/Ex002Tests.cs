using Ex002;

namespace ExerciseReflectionAndAttributesTests;

public class Ex002Tests
{
    private class Sample(string name, int age)
    {
        [MyRequired] public string Name { get; } = name;
        [MyRange(12, 90)] public int Age { get; } = age;
    }

    [TestCase("Pesho", 12, true)]
    [TestCase("Pesho", 90, true)]
    [TestCase(null, 20, false)]
    [TestCase("Pesho", 11, false)]
    [TestCase("Pesho", 91, false)]
    public void ValidatorChecksAttributes(string name, int age, bool valid)
    {
        Assert.That(Validator.IsValid(new Sample(name, age)), Is.EqualTo(valid));
    }

    [Test]
    public void ProgramReportsInvalidPerson()
    {
        Assert.That(ConsoleRunner.Run(typeof(Validator).Assembly), Is.EqualTo("False"));
    }
}
