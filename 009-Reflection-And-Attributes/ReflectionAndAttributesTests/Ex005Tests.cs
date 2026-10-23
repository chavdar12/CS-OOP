using System.Reflection;
using AuthorAttribute = Ex005.AuthorAttribute;

namespace ReflectionAndAttributesTests;

public class Ex005Tests
{
    [Test]
    public void ProgramAndMainCarryAuthors()
    {
        var main = typeof(AuthorAttribute).Assembly.EntryPoint;

        Assert.That(main.DeclaringType.GetCustomAttribute<AuthorAttribute>().Name, Is.EqualTo("Anakin"));
        Assert.That(main.GetCustomAttribute<AuthorAttribute>().Name, Is.EqualTo("DartVaider"));
    }
}
