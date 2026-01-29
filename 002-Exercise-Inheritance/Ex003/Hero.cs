namespace Ex003;

public class Hero
{
    protected Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    private string Username { get; }
    private int Level { get; }

    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
    }
}