using Ex003;

namespace PolymorphismTests;

public class Ex003Tests
{
    [Test]
    public void RectangleMeasurements()
    {
        Shape rectangle = new Rectangle(4.5, 6.5);

        Assert.That(rectangle.CalculateArea(), Is.EqualTo(29.25));
        Assert.That(rectangle.CalculatePerimeter(), Is.EqualTo(22));
        Assert.That(rectangle.Draw(), Is.EqualTo("Drawing Rectangle"));
    }

    [Test]
    public void CircleMeasurements()
    {
        Shape circle = new Circle(2);

        Assert.That(circle.CalculateArea(), Is.EqualTo(4 * Math.PI));
        Assert.That(circle.CalculatePerimeter(), Is.EqualTo(4 * Math.PI));
        Assert.That(circle.Draw(), Is.EqualTo("Drawing Circle"));
    }
}
