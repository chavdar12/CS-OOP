using Ex006;

namespace ExerciseInheritanceTests;

public class Ex006Tests
{
    private static string Lines(params string[] lines) => string.Join(Environment.NewLine, lines);

    [Test]
    public void DogToString()
    {
        Assert.That(new Dog("Rex", 3, "Male").ToString(), Is.EqualTo(Lines("Dog", "Rex 3 Male", "Woof!")));
    }

    [Test]
    public void AnimalSounds()
    {
        Assert.That(new Cat("Tom", 2, "Male").ToString(), Does.EndWith("Meow meow"));
        Assert.That(new Frog("Kermit", 1, "Male").ToString(), Does.EndWith("Ribbit"));
    }

    [Test]
    public void KittenIsFemaleAndTomcatIsMale()
    {
        Assert.That(new Kitten("Kitty", 1).ToString(), Is.EqualTo(Lines("Kitten", "Kitty 1 Female", "Meow")));
        Assert.That(new Tomcat("Tom", 4).ToString(), Is.EqualTo(Lines("Tomcat", "Tom 4 Male", "MEOW")));
    }

    [Test]
    public void NegativeAgeThrows()
    {
        var error = Assert.Throws<ArgumentException>(() => new Dog("Rex", -1, "Male"));
        Assert.That(error.Message, Is.EqualTo("Invalid input!"));
    }
}
