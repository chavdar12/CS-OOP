namespace _004;

public class RandomList : List<string>
{
    public string RandomString()
    {
        var random = new Random();
        var index = random.Next(0, Count);
        var element = base[index];
        RemoveAt(index);

        return element;
    }
}