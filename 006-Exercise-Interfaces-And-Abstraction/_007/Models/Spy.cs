using System.Text;
using _007.Interfaces;

namespace _007.Models;

public class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
    {
        CodeNumber = codeNumber;
    }

    public int CodeNumber { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine($"Code Number: {CodeNumber}");

        return sb.ToString().TrimEnd();
    }
}