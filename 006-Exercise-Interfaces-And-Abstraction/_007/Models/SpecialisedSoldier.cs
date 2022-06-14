using System.Text;
using _007.Enumerators;
using _007.Interfaces;

namespace _007.Models;

public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private Corps corps;

    protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        Corps = corps;
    }

    public string Corps
    {
        get => corps.ToString();

        private init
        {
            Corps corps;

            if (!Enum.TryParse(value, out corps)) throw new ArgumentException();

            this.corps = corps;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine($"Corps: {Corps}");

        return sb.ToString().TrimEnd();
    }
}