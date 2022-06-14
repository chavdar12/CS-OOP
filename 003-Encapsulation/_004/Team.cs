using System.Text;

namespace _004;

public class Team
{
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        Name = name;
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
    }

    private string Name { get; set; }

    private IReadOnlyCollection<Person> FirstTeam => firstTeam.AsReadOnly();

    private IReadOnlyCollection<Person> ReserveTeam => reserveTeam.AsReadOnly();


    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
            firstTeam.Add(person);
        else
            reserveTeam.Add(person);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"First team has {FirstTeam.Count} players.")
            .AppendLine($"Reserve team has {ReserveTeam.Count} players.");

        return sb.ToString().TrimEnd();
    }
}