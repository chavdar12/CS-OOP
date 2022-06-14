namespace _002;

internal class Person
{
    public Person(string fullName, int age)
    {
        Age = age;
        FullName = fullName;
    }

    [MyRange(12, 90)] private int Age { get; set; }
    [MyRequired] private string FullName { get; set; }
}