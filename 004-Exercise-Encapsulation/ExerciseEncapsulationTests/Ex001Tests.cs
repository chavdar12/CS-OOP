using Ex001;

namespace ExerciseEncapsulationTests;

public class Ex001Tests
{
    [Test]
    public void CalculatesAreasAndVolume()
    {
        var box = new Box(2, 3, 4);

        Assert.That(box.SurfaceArea(), Is.EqualTo(52));
        Assert.That(box.LateralSurfaceArea(), Is.EqualTo(40));
        Assert.That(box.Volume(), Is.EqualTo(24));
    }

    [Test]
    public void ProgramPrintsAllMeasurements()
    {
        Assert.That(ConsoleRunner.Run(typeof(Box).Assembly, "2\n3\n4\n"),
            Is.EqualTo("Surface Area - 52.00\nLateral Surface Area - 40.00\nVolume - 24.00"));
    }

    [Test]
    public void ProgramReportsInvalidSide()
    {
        Assert.That(ConsoleRunner.Run(typeof(Box).Assembly, "0\n3\n4\n"), Is.EqualTo("Length cannot be zero or negative."));
    }
}
