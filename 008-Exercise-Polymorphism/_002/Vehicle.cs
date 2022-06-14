namespace _002;

public abstract class Vehicle
{
    private double fuelQuantity;

    protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        TankCapacity = tankCapacity;
        FuelQuantity = fuelQuantity;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    protected double TankCapacity { get; set; }

    protected double FuelQuantity
    {
        get => fuelQuantity;
        set
        {
            if (value > TankCapacity)
                fuelQuantity = 0;
            else
                fuelQuantity = value;
        }
    }

    protected virtual double FuelConsumptionPerKm { get; set; }

    public abstract void Drive(double distance);

    public virtual void DriveEmpty(double distance)
    {
    }

    public abstract void Refuel(double amount);

    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:f2}";
    }
}