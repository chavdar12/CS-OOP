using System.Text;

namespace _001;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    private string Name { get; set; }

    private int Age { get; set; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Name: {Name}, Age: {Age}");

        return stringBuilder.ToString();
    }
}