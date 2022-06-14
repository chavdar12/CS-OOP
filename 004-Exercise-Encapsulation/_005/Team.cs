namespace _005;

public class Team
{
    private string name;
    private List<Player> players;

    public Team(string name)
    {
        Name = name;
        players = new List<Player>();
    }

    private string Name
    {
        get => name;
        init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("A name should not be empty.");
            name = value;
        }
    }

    public int Rating
        => players.Count == 0 ? 0 : (int) Math.Round(players.Average(p => p.Stats));

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void RemovePlayer(string playerName)
    {
        var player = players.FirstOrDefault(p => p.Name == playerName);

        if (player == null) throw new InvalidOperationException($"Player {playerName} is not in {Name} team.");
        players.Remove(player);
    }
}