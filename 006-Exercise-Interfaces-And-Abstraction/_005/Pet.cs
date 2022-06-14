namespace _005;

public class Pet : IPetName
{
    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

    public string Name { get; private set; }
    public string Birthdate { get; private set; }
}