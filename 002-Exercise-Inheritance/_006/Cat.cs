namespace _006;

public class Cat : Animal
{
    protected Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    protected override string ProduceSound()
    {
        return "Meow meow";
    }
}