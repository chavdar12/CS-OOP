using System.Reflection;
using System.Runtime.ExceptionServices;

// Programs parse and format numbers with the current culture; pin it so results don't depend on the machine's locale.
[assembly: SetCulture("en-US")]

// Runs a console program's entry point in-process with the given stdin and returns what it wrote to stdout.
public static class ConsoleRunner
{
    public static string Run(Assembly program, string input = "")
    {
        var originalIn = Console.In;
        var originalOut = Console.Out;
        var output = new StringWriter();

        try
        {
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);

            var main = program.EntryPoint ?? throw new ArgumentException($"{program.GetName().Name} has no entry point.");
            main.Invoke(null, main.GetParameters().Length == 0 ? null : new object[] { Array.Empty<string>() });
        }
        catch (TargetInvocationException e) when (e.InnerException != null)
        {
            ExceptionDispatchInfo.Capture(e.InnerException).Throw();
        }
        finally
        {
            Console.SetIn(originalIn);
            Console.SetOut(originalOut);
        }

        return output.ToString().ReplaceLineEndings("\n").TrimEnd();
    }
}
