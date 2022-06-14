namespace _005;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var allEntities = new List<IBirthable>();
        var command = Console.ReadLine();

        while (command != "End")
        {
            var operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var type = operations[0];

            if (type == nameof(Citizen))
            {
                var guy = new Citizen(operations[1], int.Parse(operations[2]), operations[3], operations[4]);
                allEntities.Add(guy);
            }
            else if (type == nameof(Pet))
            {
                var pet = new Pet(operations[1], operations[2]);
                allEntities.Add(pet);
            }

            command = Console.ReadLine();
        }

        var year = Console.ReadLine();

        var targets = allEntities
            .Where(x => x.Birthdate.EndsWith(year))
            .ToList();

        foreach (var date in targets) Console.WriteLine(date.Birthdate);
    }
}