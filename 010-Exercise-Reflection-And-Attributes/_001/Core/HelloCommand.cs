using _001.Core.Contracts;

namespace _001.Core;

public class HelloCommand : ICommand
{
    public string Execute(string[] args)
    {
        return $"Hello, {args[0]}";
    }
}