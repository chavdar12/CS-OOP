namespace _008;

public class MyList : AddRemoveCollection, IMyList
{
    public int Used => Data.Count;

    public override string Remove()
    {
        var element = Data.First();
        Data.Remove(element);

        return element;
    }
}