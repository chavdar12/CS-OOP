using Ex002;

namespace ExercisePolymorphismTests;

public class Ex002Tests
{
    [Test]
    public void OverfilledTankStartsEmpty()
    {
        Assert.That(new Car(80, 1, 70).ToString(), Is.EqualTo("Car: 0.00"));
    }

    [Test]
    public void ProgramHandlesRefuelLimitsAndBus()
    {
        var output = ConsoleRunner.Run(typeof(Vehicle).Assembly,
            "Car 30 0.04 70\nTruck 100 0.5 300\nBus 40 0.3 150\n8\nRefuel Car -10\nRefuel Truck 0\n" +
            "Refuel Car 10\nRefuel Car 300\nDrive Bus 10\nRefuel Bus 1000\nDriveEmpty Bus 100\nRefuel Truck 1000\n");

        Assert.That(output, Is.EqualTo(
            "Fuel must be a positive number\nFuel must be a positive number\nCannot fit 300 fuel in the tank\n" +
            "Bus travelled 10 km\nCannot fit 1000 fuel in the tank\nBus needs refueling\n" +
            "Cannot fit 1000 fuel in the tank\nCar: 40.00\nTruck: 100.00\nBus: 23.00"));
    }
}
