using Ex004;

namespace ExerciseInheritanceTests;

public class Ex004Tests
{
    [TestCase(typeof(CrossMotorcycle), 1.25)]
    [TestCase(typeof(RaceMotorcycle), 8)]
    [TestCase(typeof(FamilyCar), 3)]
    [TestCase(typeof(SportCar), 10)]
    public void DriveUsesTheVehiclesFuelConsumption(Type type, double consumption)
    {
        var vehicle = (Vehicle)Activator.CreateInstance(type, 100, 50.0);

        vehicle.Drive(2);

        Assert.That(vehicle.FuelConsumption, Is.EqualTo(consumption));
        Assert.That(vehicle.Fuel, Is.EqualTo(50 - 2 * consumption));
        Assert.That(vehicle.HorsePower, Is.EqualTo(100));
    }
}
