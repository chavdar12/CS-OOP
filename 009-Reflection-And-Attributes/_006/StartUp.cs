namespace _006;

[Author("Anakin")]
public class StartUp
{
    [Author("DartVayder")]
    private static void Main(string[] args)
    {
        var tracker = new Tracker();
        Tracker.PrintMethodsByAuthor();
    }
}