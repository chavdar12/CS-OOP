namespace Ex004;

public class Vehicle
{
    private const double DefaultFuelConsumption = 1.25;

    protected Vehicle(int horsePower, double fuel)
    {
        HorsePower = horsePower;
        Fuel = fuel;
    }

    public virtual double FuelConsumption => DefaultFuelConsumption;
    public double Fuel { get; private set; }
    public int HorsePower { get; }

    public virtual void Drive(double kilometers)
    {
        Fuel -= kilometers * FuelConsumption;
    }
}