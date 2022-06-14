using System.Text;
using _007.Interfaces;

namespace _007.Models;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, decimal salary, string corps, IList<Mission> missions)
        : base(id, firstName, lastName, salary, corps)
    {
        Missions = missions;
    }

    public IList<Mission> Missions { get; private set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine("Missions:");

        foreach (var mission in Missions) sb.AppendLine(mission.ToString());

        return sb.ToString().TrimEnd();
    }
}