namespace Ex008;

public class AddRemoveCollection : CustomCollection, IRemove
{
    public virtual string Remove()
    {
        var element = Data[^1];
        Data.Remove(element);

        return element;
    }

    public override int Add(string item)
    {
        Data.Insert(0, item);

        return 0;
    }
}