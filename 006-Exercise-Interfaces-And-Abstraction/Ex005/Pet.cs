namespace Ex005;

public class Pet : IPetName
{
    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

    public string Name { get; }
    public string Birthdate { get; }
}