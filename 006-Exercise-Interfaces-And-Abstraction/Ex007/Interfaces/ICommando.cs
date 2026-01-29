using Ex007.Models;

namespace Ex007.Interfaces;

public interface ICommando
{
    IList<Mission> Missions { get; }
}