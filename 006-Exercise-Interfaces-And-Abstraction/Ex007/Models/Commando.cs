using System.Text;
using Ex007.Interfaces;

namespace Ex007.Models;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, decimal salary, string corps, IList<Mission> missions)
        : base(id, firstName, lastName, salary, corps)
    {
        Missions = missions;
    }

    public IList<Mission> Missions { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine("Missions:");

        foreach (var mission in Missions) sb.AppendLine(mission.ToString());

        return sb.ToString().TrimEnd();
    }
}