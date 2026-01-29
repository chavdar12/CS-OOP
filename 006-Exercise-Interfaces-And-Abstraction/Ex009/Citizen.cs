namespace Ex009;

public class Citizen : IResident, IPerson
{
    public Citizen(string name, int age, string country)
    {
        Name = name;
        Age = age;
        Country = country;
    }

    public int Age { get; }

    public void GetName()
    {
        Console.WriteLine(Name);
    }

    public string Name { get; }
    public string Country { get; }

    void IResident.GetName()
    {
        Console.WriteLine($"Mr/Ms/Mrs {Name}");
    }
}