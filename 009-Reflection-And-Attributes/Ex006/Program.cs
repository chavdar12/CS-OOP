namespace Ex006;

[Author("Anakin")]
internal class Program
{
    [Author("DartVayder")]
    public static void Main(string[] args)
    {
        var tracker = new Tracker();
        Tracker.PrintMethodsByAuthor();
    }
}