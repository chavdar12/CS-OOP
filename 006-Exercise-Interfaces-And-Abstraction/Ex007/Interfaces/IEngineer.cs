using Ex007.Models;

namespace Ex007.Interfaces;

public interface IEngineer
{
    IList<Repair> Repairs { get; }
}