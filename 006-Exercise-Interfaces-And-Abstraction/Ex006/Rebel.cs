namespace Ex006;

public class Rebel : IBuyer
{
    private string group;

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    private string Group { get; set; }

    public string Name { get; }
    public int Age { get; }
    public int Food { get; private set; }

    public void BuyFood()
    {
        Food += 5;
    }
}