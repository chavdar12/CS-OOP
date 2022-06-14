namespace _003;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var spy = new Spy();
        var className = typeof(Hacker).FullName;
        var result = Spy.RevealPrivateMethods(className);
        Console.WriteLine(result);
    }
}