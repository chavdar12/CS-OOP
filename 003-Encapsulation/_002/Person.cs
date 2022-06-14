namespace _002;

public class Person
{
    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    private string FirstName { get; set; }
    private string LastName { get; set; }
    private int Age { get; set; }
    private decimal Salary { get; set; }

    public void IncreaseSalary(decimal percentage)
    {
        if (Age > 30)
            Salary += Salary * percentage / 100;
        else
            Salary += Salary * percentage / 200;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:F2} leva.";
    }
}