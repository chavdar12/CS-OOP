using _007.Models;

namespace _007.Interfaces;

public interface ICommando
{
    IList<Mission> Missions { get; }
}