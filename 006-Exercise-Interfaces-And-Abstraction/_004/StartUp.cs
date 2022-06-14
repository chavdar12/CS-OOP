namespace _004;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var allEntities = new List<IIdentifiable>();
        var command = Console.ReadLine();

        while (command != "End")
        {
            var operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            switch (operations.Length)
            {
                case 2:
                {
                    var terminator = new Robot(operations[0], operations[1]);
                    allEntities.Add(terminator);
                    break;
                }
                case 3:
                {
                    var guy = new Citizen(operations[0], int.Parse(operations[1]), operations[2]);
                    allEntities.Add(guy);
                    break;
                }
            }

            command = Console.ReadLine();
        }

        var numbers = Console.ReadLine();

        var detained = allEntities
            .Where(x => x.Id.EndsWith(numbers))
            .Select(x => x.Id)
            .ToList();

        Console.WriteLine(string.Join(Environment.NewLine, detained));
    }
}