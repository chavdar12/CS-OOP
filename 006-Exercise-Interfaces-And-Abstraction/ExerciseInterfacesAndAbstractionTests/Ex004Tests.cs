using Ex004;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex004Tests
{
    [Test]
    public void ProgramDetainsIdsWithFakeSuffix()
    {
        var output = ConsoleRunner.Run(typeof(Robot).Assembly,
            "Peter 22 9010101122\nMK-13 558833251\nMK-12 33283122\nEnd\n122\n");

        Assert.That(output, Is.EqualTo("9010101122\n33283122"));
    }
}
