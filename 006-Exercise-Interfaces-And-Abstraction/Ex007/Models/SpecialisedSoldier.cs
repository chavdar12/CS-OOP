using System.Text;
using Ex007.Enumerators;
using Ex007.Interfaces;

namespace Ex007.Models;

public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private readonly Corps corps;

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