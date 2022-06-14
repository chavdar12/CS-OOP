namespace _001;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        if (age < 0) return;

        var person = age <= 15 ? new Child(name, age) : new Person(name, age);

        Console.WriteLine(person);
    }
}