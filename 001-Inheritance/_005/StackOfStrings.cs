namespace _005;

public class StackOfStrings : Stack<string>
{
    public bool IsEmpty()
    {
        return Count == 0;
    }

    public void AddRange(List<string> collection)
    {
        foreach (var element in collection) Push(element);
    }
}