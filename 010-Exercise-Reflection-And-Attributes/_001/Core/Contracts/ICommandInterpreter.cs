namespace _001.Core.Contracts;

public interface ICommandInterpreter
{
    string Read(string args);
}