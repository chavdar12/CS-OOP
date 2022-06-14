namespace _006;

public class Kitten : Cat
{
    private const string gender = "Female";

    public Kitten(string name, int age) : base(name, age, gender)
    {
    }

    protected override string ProduceSound()
    {
        return "Meow";
    }
}