using Ex004;

namespace InheritanceTests;

public class Ex004Tests
{
    [Test]
    public void RandomStringRemovesAndReturnsAnElement()
    {
        var list = new RandomList { "a", "b", "c" };

        var element = list.RandomString();

        Assert.That(new[] { "a", "b", "c" }, Does.Contain(element));
        Assert.That(list, Has.Count.EqualTo(2));
        Assert.That(list, Does.Not.Contain(element));
    }
}
