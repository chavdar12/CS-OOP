using Ex003;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex003Tests
{
    [Test]
    public void PhonesRejectInvalidInput()
    {
        Assert.That(new Smartphone().Call("08821a4215"), Is.EqualTo("Invalid number!"));
        Assert.That(new StationaryPhone().Call("055a123"), Is.EqualTo("Invalid number!"));
        Assert.That(new Smartphone().Browse("http://www.g00gle.com"), Is.EqualTo("Invalid URL!"));
    }

    [Test]
    public void ProgramCallsDialsAndBrowses()
    {
        var output = ConsoleRunner.Run(typeof(Smartphone).Assembly,
            "0882134215 08992134215 0558123 3333\nhttp://softuni.bg http://www.g00gle.com\n");

        Assert.That(output, Is.EqualTo(
            "Calling... 0882134215\nInvalid number!\nDialing... 0558123\nInvalid number!\n" +
            "Browsing: http://softuni.bg!\nInvalid URL!"));
    }
}
