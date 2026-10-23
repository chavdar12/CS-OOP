using Ex003;

namespace ReflectionAndAttributesTests;

public class Ex003Tests
{
    [Test]
    public void RevealsBaseClassAndPrivateMethods()
    {
        var lines = Spy.RevealPrivateMethods(typeof(Hacker).FullName).ReplaceLineEndings("\n").Split('\n');

        Assert.That(lines[0], Is.EqualTo("All Private Methods of Class: Ex003.Hacker"));
        Assert.That(lines[1], Is.EqualTo("Base Class: Object"));
        Assert.That(lines, Is.SupersetOf(new[] { "get_Id", "set_Id", "get_BankAccountBalance", "set_BankAccountBalance" }));
    }
}
