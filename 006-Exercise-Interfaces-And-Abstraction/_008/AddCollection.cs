namespace _008;

public class AddCollection : CustomCollection
{
    public override int Add(string item)
    {
        Data.Add(item);

        return Data.Count - 1;
    }
}