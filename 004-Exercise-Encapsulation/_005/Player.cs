namespace _005;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public string Name
    {
        get => name;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("A name should not be empty.");
            name = value;
        }
    }

    public int Endurance
    {
        get => endurance;
        private init
        {
            ValidateStat(nameof(Endurance), value);
            endurance = value;
        }
    }

    public int Sprint
    {
        get => sprint;
        private init
        {
            ValidateStat(nameof(Sprint), value);
            sprint = value;
        }
    }

    public int Dribble
    {
        get => dribble;
        private init
        {
            ValidateStat(nameof(Dribble), value);
            dribble = value;
        }
    }

    public int Passing
    {
        get => passing;
        private init
        {
            ValidateStat(nameof(Passing), value);
            passing = value;
        }
    }

    public int Shooting
    {
        get => shooting;
        private init
        {
            ValidateStat(nameof(Shooting), value);
            shooting = value;
        }
    }

    public double Stats
        => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;

    private static void ValidateStat(string varName, int value)
    {
        if (value is < 1 or > 100) throw new ArgumentException($"{varName} should be between 0 and 100.");
    }
}