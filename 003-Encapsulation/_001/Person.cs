namespace _001;

public class Person
{
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; private set; }
    private string LastName { get; set; }
    public int Age { get; private set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}