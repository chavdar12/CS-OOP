using _007.Models;

namespace _007.Interfaces;

public interface IEngineer
{
    IList<Repair> Repairs { get; }
}