namespace _002.Models;

public class Chicken
{
    private const int MinAge = 0;
    private const int MaxAge = 15;

    private string name;
    private int age;

    public Chicken(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name
    {
        get => name;

        private set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty.");
            name = value;
        }
    }

    public int Age
    {
        get => age;

        private init
        {
            if (value is < MinAge or > MaxAge) throw new ArgumentException("Age should be between 0 and 15.");
            age = value;
        }
    }

    public double ProductPerDay => CalculateProductPerDay();

    private double CalculateProductPerDay()
    {
        return Age switch
        {
            <= 3 => 1.5,
            > 3 and <= 7 => 2,
            > 7 and <= 11 => 1,
            _ => 0.75
        };
    }
}