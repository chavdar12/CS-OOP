using Ex001.Core;

namespace ExerciseReflectionAndAttributesTests;

public class Ex001Tests
{
    [Test]
    public void InterpreterRunsHelloCommand()
    {
        Assert.That(new CommandInterpreter().Read("Hello Pesho"), Is.EqualTo("Hello, Pesho"));
    }

    [Test]
    public void InterpreterRejectsUnknownCommand()
    {
        var error = Assert.Throws<ArgumentException>(() => new CommandInterpreter().Read("Bogus"));
        Assert.That(error.Message, Is.EqualTo("Invalid command type!"));
    }

    [Test]
    public void ProgramRunsUntilEndOfInput()
    {
        Assert.That(ConsoleRunner.Run(typeof(Engine).Assembly, "Hello Pesho\nBogus\n"),
            Is.EqualTo("Hello, Pesho\nInvalid command type!"));
    }
}
