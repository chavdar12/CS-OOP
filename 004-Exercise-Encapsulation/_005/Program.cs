namespace _005;

public static class Program
{
    public static void Main(string[] args)
    {
        var teams = new Dictionary<string, Team>();
        var command = Console.ReadLine();

        while (command != "END")
        {
            var commandInfo = command.Split(';');
            var action = commandInfo[0];

            try
            {
                switch (action)
                {
                    case "Team":
                    {
                        var name = commandInfo[1];
                        var team = new Team(name);
                        teams.Add(name, team);
                        break;
                    }
                    case "Add":
                    {
                        var teamName = commandInfo[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        var playerName = commandInfo[2];
                        var endurance = int.Parse(commandInfo[3]);
                        var sprint = int.Parse(commandInfo[4]);
                        var dribble = int.Parse(commandInfo[5]);
                        var passing = int.Parse(commandInfo[6]);
                        var shooting = int.Parse(commandInfo[7]);

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        teams[teamName].AddPlayer(player);
                        break;
                    }
                    case "Remove":
                    {
                        var teamName = commandInfo[1];
                        var playerName = commandInfo[2];
                        teams[teamName].RemovePlayer(playerName);
                        break;
                    }
                    case "Rating":
                    {
                        var teamName = commandInfo[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            command = Console.ReadLine();
        }
    }
}