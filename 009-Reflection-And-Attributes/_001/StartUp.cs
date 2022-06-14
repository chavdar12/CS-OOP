namespace _001;

public static class StartUp
{
    private static void Main(string[] args)
    {
        try
        {
            var className = typeof(Hacker).FullName;
            var result = Spy.StealFieldInfo(className, "username", "password");
            Console.WriteLine(result);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Value cannot be null!");
        }
    }
}