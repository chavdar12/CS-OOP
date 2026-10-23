using Ex002;

namespace InterfacesAndAbstractionTests;

public class Ex002Tests
{
    [Test]
    public void CarsStartAndStop()
    {
        ICar seat = new Seat("Leon", "Grey");

        Assert.That(seat.Start(), Is.EqualTo("Engine start"));
        Assert.That(seat.Stop(), Is.EqualTo("Breaaak!"));
    }

    [Test]
    public void TeslaIsElectric()
    {
        Assert.That(new Tesla("Model 3", "Red", 2), Is.InstanceOf<IElectricCar>().And.InstanceOf<ICar>());
    }

    [Test]
    public void ProgramDescribesBothCars()
    {
        Assert.That(ConsoleRunner.Run(typeof(ICar).Assembly),
            Is.EqualTo("Grey Seat Leon\nRed Tesla Model 3 with 2 Batteries"));
    }
}
