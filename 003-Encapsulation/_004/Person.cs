namespace _004;

public abstract class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    protected Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    private string FirstName
    {
        get => firstName;
        init
        {
            if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            firstName = value;
        }
    }

    private string LastName
    {
        get => lastName;
        init
        {
            if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            lastName = value;
        }
    }

    public int Age
    {
        get => age;
        private init
        {
            if (value <= 0) throw new ArgumentException("Age cannot be zero or a negative integer!");
            age = value;
        }
    }

    private decimal Salary
    {
        get => salary;
        set
        {
            if (value < 650) throw new ArgumentException("Salary cannot be less than 650 leva!");
            salary = value;
        }
    }

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