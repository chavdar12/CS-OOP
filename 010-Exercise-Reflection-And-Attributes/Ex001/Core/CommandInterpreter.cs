using System.Reflection;
using Ex001.Core.Contracts;

namespace Ex001.Core;

public class CommandInterpreter : ICommandInterpreter
{
    public string Read(string args)
    {
        var input = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var commandName = (input[0] + "Command").ToLower();

        var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(n => n.Name.ToLower() == commandName);
        //Console.WriteLine((Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(n => n.Name.ToLower() == commandName).Assembly.Get().Name));
        var instance =
            (ICommand)Activator.CreateInstance(type ?? throw new ArgumentException("Invalid command type!"));
        var result = instance?.Execute(input.Skip(1).ToArray());
        return result;
    }
}