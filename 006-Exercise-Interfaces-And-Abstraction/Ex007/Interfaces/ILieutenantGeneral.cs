using Ex007.Models;

namespace Ex007.Interfaces;

public interface ILieutenantGeneral
{
    IList<Private> Privates { get; }
}