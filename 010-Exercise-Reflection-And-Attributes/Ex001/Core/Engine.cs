using Ex001.Core.Contracts;

namespace Ex001.Core;

public class Engine : IEngine
{
    private readonly ICommandInterpreter commandInterpreter;

    public Engine(ICommandInterpreter commandInterpreter)
    {
        this.commandInterpreter = commandInterpreter;
    }

    public void Run()
    {
        string input;

        while ((input = Console.ReadLine()) != null)
            try
            {
                var result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
    }
}