using Ex004;

namespace ReflectionAndAttributesTests;

public class Ex004Tests
{
    [Test]
    public void ProgramListsGettersAndSetterParameterTypes()
    {
        Assert.That(ConsoleRunner.Run(typeof(Spy).Assembly), Is.EqualTo(
            "get_Password will return System.String\nget_Id will return System.Int32\n" +
            "get_BankAccountBalance will return System.Double\nset_Password will set field of System.String\n" +
            "set_Id will set field of System.Int32\nset_BankAccountBalance will set field of System.Double"));
    }
}
