using Ex005;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex005Tests
{
    [Test]
    public void ProgramPrintsBirthdatesInYear()
    {
        var output = ConsoleRunner.Run(typeof(Pet).Assembly,
            "Citizen Peter 22 9010101122 10/10/1990\nPet Sharo 13/11/2005\nRobot MK-13 558833251\n" +
            "Pet Rex 01/01/1990\nEnd\n1990\n");

        Assert.That(output, Is.EqualTo("10/10/1990\n01/01/1990"));
    }
}
