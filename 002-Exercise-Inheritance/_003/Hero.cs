namespace _003;

public class Hero
{
    protected Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    private string Username { get; set; }
    private int Level { get; set; }

    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
    }
}