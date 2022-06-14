namespace _004;

public class RaceMotorcycle : Motorcycle
{
    private const double DefaultFuelConsumption = 8;

    public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }

    protected override double FuelConsumption => DefaultFuelConsumption;
}