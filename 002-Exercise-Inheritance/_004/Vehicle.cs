namespace _004;

public class Vehicle
{
    private const double DefaultFuelConsumption = 1.25;

    protected Vehicle(int horsePower, double fuel)
    {
        HorsePower = horsePower;
        Fuel = fuel;
        FuelConsumption = DefaultFuelConsumption;
    }

    protected virtual double FuelConsumption { get; set; }
    private double Fuel { get; set; }
    private int HorsePower { get; set; }

    public virtual void Drive(double kilometers)
    {
        Fuel -= kilometers * FuelConsumption;
    }
}