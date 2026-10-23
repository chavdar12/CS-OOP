using Ex001;

namespace ExercisePolymorphismTests;

public class Ex001Tests
{
    [Test]
    public void TruckKeepsNinetyFivePercentOfRefuel()
    {
        var truck = new Truck(0, 1);

        truck.Refuel(100);

        Assert.That(truck.ToString(), Is.EqualTo("Truck: 95.00"));
    }

    [Test]
    public void ProgramDrivesAndRefuels()
    {
        var output = ConsoleRunner.Run(typeof(Vehicle).Assembly,
            "Car 15 0.3\nTruck 100 0.9\n4\nDrive Car 9\nDrive Car 30\nRefuel Car 50\nDrive Truck 10\n");

        Assert.That(output, Is.EqualTo(
            "Car travelled 9 km\nCar needs refueling\nTruck travelled 10 km\nCar: 54.20\nTruck: 75.00"));
    }
}
