namespace _006;

public class Tomcat : Cat
{
    private const string gender = "Male";

    public Tomcat(string name, int age) : base(name, age, gender)
    {
    }

    protected override string ProduceSound()
    {
        return "MEOW";
    }
}