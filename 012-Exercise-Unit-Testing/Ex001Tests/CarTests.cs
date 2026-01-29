using Ex001;

namespace Ex001Tests;

public class CarTests
{
    private Car car;
    private double fuelAmount;

    [SetUp]
    public void Setup()
    {
        car = new Car("Audi", "A3", 40, 100);
        fuelAmount = 0;
    }

    [Test]
    public void VerifyConstructor()
    {
        Assert.That(car, Is.Not.Null, "The constructor is broken!");
    }

    [Test]
    public void VerifyMakeProperty()
    {
        Assert.That(car.Make, Is.EqualTo("Audi"), "Property isn't working right!");
    }

    [Test]
    public void MakePropertyThrowsExceptionIfNullOrEmpty()
    {
        Assert.Throws<ArgumentException>(() => car = new Car(null, "Some", 10, 10));
    }

    [Test]
    public void VerifyModelProperty()
    {
        Assert.That(car.Model, Is.EqualTo("A3"), "Property isn't working right!");
    }

    [Test]
    public void ModelPropertyThrowsExceptionIfNullOrEmpty()
    {
        Assert.Throws<ArgumentException>(() => car = new Car("Some", null, 10, 10));
    }

    [Test]
    public void VerifyFuelConsProperty()
    {
        Assert.That(car.FuelConsumption, Is.EqualTo(40), "Property isn't working right!");
    }

    [Test]
    public void FuelConsPropertyThrowsExceptionIfValueIsNegativeOrZero()
    {
        Assert.Throws<ArgumentException>(() => car = new Car("Some", "Car", 0, 10));
        Assert.Throws<ArgumentException>(() => car = new Car("Some", "Car", -10, 10));
    }

    [Test]
    public void VerifyFuelAmountProperty()
    {
        Assert.That(car.FuelAmount, Is.EqualTo(0), "Property isn't working right!");
    }

    [Test]
    public void FuelAmountPropertyThrowsExceptionIfValueIsNegative()
    {
        Assert.That(() => car.Refuel(0), Throws.InstanceOf<ArgumentException>());
    }

    [Test]
    public void VerifyFuelCapacityProperty()
    {
        Assert.That(car.FuelCapacity, Is.EqualTo(100), "Property isn't working right!");
    }

    [Test]
    public void FuelCapacityPropertyThrowsExceptionIfValueIsNegativeOrZero()
    {
        Assert.Throws<ArgumentException>(() => car = new Car("Some", "Car", 10, 0));
        Assert.Throws<ArgumentException>(() => car = new Car("Some", "Car", 10, -10));
    }

    [Test]
    public void VerifyRefuelMethod()
    {
        car.Refuel(20);
        var currentAmount = car.FuelAmount;
        const double expected = 20;
        Assert.That(currentAmount, Is.EqualTo(expected), "The car isn't refueling right!");
    }

    [Test]
    public void FuelIsSetToMaxCapacityWhenGoingOverTheAllowed()
    {
        car.Refuel(150);
        var currentAmount = car.FuelAmount;
        Assert.That(currentAmount, Is.EqualTo(car.FuelCapacity));
    }

    [Test]
    public void RefuelMethodThrowsExceptionIfValueIsNegativeOrZero()
    {
        Assert.Throws<ArgumentException>(() => car.Refuel(0));
        Assert.Throws<ArgumentException>(() => car.Refuel(-10));
    }

    [Test]
    public void VerifyDriveMethod()
    {
        car.Refuel(30);
        car.Drive(30);
        const double expected = 18;
        var currentAmount = car.FuelAmount;
        Assert.That(currentAmount, Is.EqualTo(expected), "The method isn't working right!");
    }

    [Test]
    public void DriveMethodThrowsExceptionIfFuelNeededIsLessThanCurrentAmount()
    {
        Assert.Throws<InvalidOperationException>(() => car.Drive(200.00));
    }
}