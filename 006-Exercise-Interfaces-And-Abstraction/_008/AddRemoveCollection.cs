namespace _008;

public class AddRemoveCollection : CustomCollection, IRemove
{
    public override int Add(string item)
    {
        Data.Insert(0, item);

        return 0;
    }

    public virtual string Remove()
    {
        var element = Data[^1];
        Data.Remove(element);

        return element;
    }
}