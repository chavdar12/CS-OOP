namespace _001;

public abstract class Vehicle
{
    protected virtual double FuelQuantity { get; set; }
    public virtual double FuelConsumptionPerKm { get; set; }

    public virtual string Drive(double distance)
    {
        return null;
    }

    public virtual void Refuel(double amount)
    {
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {FuelQuantity:f2}";
    }
}