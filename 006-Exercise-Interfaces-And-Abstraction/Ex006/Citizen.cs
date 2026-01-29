namespace Ex006;

public class Citizen : IBuyer, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public string Birthdate { get; }

    public string Name { get; }
    public int Age { get; }
    public int Food { get; private set; }

    public void BuyFood()
    {
        Food += 10;
    }

    public string Id { get; }
}