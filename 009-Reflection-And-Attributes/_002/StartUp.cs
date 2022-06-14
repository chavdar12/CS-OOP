namespace _002;

public static class StartUp
{
    private static void Main(string[] args)
    {
        try
        {
            var className = typeof(Hacker).FullName;
            var result = Spy.AnalyzeAccessModifiers(className);
            Console.WriteLine(result);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Value cannot be null!");
        }
    }
}