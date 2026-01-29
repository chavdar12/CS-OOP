using System.Text;

namespace Ex001;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    private string Name { get; }

    private int Age { get; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Name: {Name}, Age: {Age}");

        return stringBuilder.ToString();
    }
}