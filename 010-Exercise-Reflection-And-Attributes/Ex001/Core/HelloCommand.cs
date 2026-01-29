using Ex001.Core.Contracts;

namespace Ex001.Core;

public class HelloCommand : ICommand
{
    public string Execute(string[] args)
    {
        return $"Hello, {args[0]}";
    }
}