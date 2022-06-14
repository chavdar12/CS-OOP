namespace _004;

public static class StartUp
{
    public static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();

        var team = new Team("SoftUni");
        for (var i = 0; i < lines; i++)
        {
            var personArguments = Console.ReadLine()
                .Split()
                .ToArray();

            var firstName = personArguments[0];
            var lastName = personArguments[1];
            var age = int.Parse(personArguments[2]);
            var salary = decimal.Parse(personArguments[3]);
        }

        foreach (var person in persons) team.AddPlayer(person);
        Console.WriteLine(team);
    }
}