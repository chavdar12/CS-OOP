namespace _004;

public class Car : Vehicle
{
    private const double DefaultFuelConsumption = 3;

    protected Car(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }

    protected override double FuelConsumption => DefaultFuelConsumption;
}