using _001.Core;
using _001.Core.Contracts;
using CommandPattern.Core;

namespace _001;

public static class StartUp
{
    public static void Main(string[] args)
    {
        ICommandInterpreter command = new CommandInterpreter();
        IEngine engine = new Engine(command);
        engine.Run();
    }
}