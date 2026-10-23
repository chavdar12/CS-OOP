using Ex005;

namespace InheritanceTests;

public class Ex005Tests
{
    [Test]
    public void NewStackIsEmpty()
    {
        Assert.That(new StackOfStrings().IsEmpty(), Is.True);
    }

    [Test]
    public void AddRangePushesInOrder()
    {
        var stack = new StackOfStrings();

        stack.AddRange(new List<string> { "a", "b", "c" });

        Assert.That(stack.IsEmpty(), Is.False);
        Assert.That(stack.Pop(), Is.EqualTo("c"));
        Assert.That(stack, Has.Count.EqualTo(2));
    }
}
