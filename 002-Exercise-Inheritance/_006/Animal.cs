using System.Text;

namespace _006;

public class Animal
{
    private int age;

    protected Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    private string Name { get; set; }

    private int Age
    {
        get => age;
        set
        {
            if (value < 0) throw new ArgumentException("Invalid input!");
            age = value;
        }
    }

    protected virtual string Gender { get; set; }

    protected virtual string ProduceSound()
    {
        return null;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{GetType().Name}");
        sb.AppendLine($"{Name} {Age} {Gender}");
        sb.AppendLine($"{ProduceSound()}");

        return sb.ToString().TrimEnd();
    }
}