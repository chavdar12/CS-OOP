namespace _006;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var allEntities = new List<IBuyer>();
        var times = int.Parse(Console.ReadLine());

        for (var i = 0; i < times; i++)
        {
            var operations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = operations[0];
            if (allEntities.Any(x => x.Name == name)) continue;
            switch (operations.Length)
            {
                case 3:
                {
                    var rebel = new Rebel(operations[0], int.Parse(operations[1]), operations[2]);
                    allEntities.Add(rebel);
                    break;
                }
                case 4:
                {
                    var guy = new Citizen(operations[0], int.Parse(operations[1]), operations[2], operations[3]);
                    allEntities.Add(guy);
                    break;
                }
            }
        }

        var client = Console.ReadLine();

        while (client != "End")
        {
            var currentBuyer = allEntities.FirstOrDefault(x => x.Name == client);
            currentBuyer?.BuyFood();
            client = Console.ReadLine();
        }

        Console.WriteLine(allEntities.Sum(x => x.Food));
    }
}