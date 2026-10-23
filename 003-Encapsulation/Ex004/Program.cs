using Ex004;

var lines = int.Parse(Console.ReadLine());
var team = new Team("SoftUni");

for (var i = 0; i < lines; i++)
    try
    {
        var cmdArgs = Console.ReadLine().Split();
        team.AddPlayer(new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3])));
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

Console.WriteLine(team);
