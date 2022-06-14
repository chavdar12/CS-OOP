namespace _006;

public class Rebel : IBuyer
{
    private string group;

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
    private string Group { get; set; }
    public int Food { get; private set; } = 0;

    public void BuyFood()
    {
        Food += 5;
    }
}