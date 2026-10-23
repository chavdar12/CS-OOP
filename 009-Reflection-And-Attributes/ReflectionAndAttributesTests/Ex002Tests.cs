using Ex002;

namespace ReflectionAndAttributesTests;

public class Ex002Tests
{
    [Test]
    public void ProgramFlagsWrongAccessModifiers()
    {
        Assert.That(ConsoleRunner.Run(typeof(Spy).Assembly), Is.EqualTo(
            "username must be private!\nget_Id have to be public!\nget_BankAccountBalance have to be public!\n" +
            "set_Password have to be private!"));
    }
}
