using Ex001;

namespace InterfacesAndAbstractionTests;

public class Ex001Tests
{
    [Test]
    public void ProgramDrawsCircleAndRectangleOfFullHeight()
    {
        var output = ConsoleRunner.Run(typeof(IDrawable).Assembly, "1\n4\n3\n");

        Assert.That(output, Is.EqualTo(" *** \n*   *\n *** \n****\n*  *\n****"));
    }
}
