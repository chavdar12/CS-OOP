namespace Ex003;

public class Smartphone : ICalling, IBrowsing
{
    public string Browse(string url)
    {
        return url.Any(char.IsDigit) ? "Invalid URL!" : $"Browsing: {url}!";
    }

    public string Call(string number)
    {
        return number.All(char.IsDigit) ? $"Calling... {number}" : "Invalid number!";
    }
}