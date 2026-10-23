using Ex001;

namespace ReflectionAndAttributesTests;

public class Ex001Tests
{
    [Test]
    public void ProgramStealsRequestedFields()
    {
        Assert.That(ConsoleRunner.Run(typeof(Spy).Assembly), Is.EqualTo(
            "Class under investigation: Ex001.Hacker\nusername = securityGod82\npassword = mySuperSecretPassw0rd"));
    }
}
