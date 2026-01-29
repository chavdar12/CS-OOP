using Ex001.Core;
using Ex001.Core.Contracts;

ICommandInterpreter command = new CommandInterpreter();
IEngine engine = new Engine(command);
engine.Run();