namespace Ex001Tests;

[TestFixture]
public class AxeTests
{
    [SetUp]
    public void SettingUpSubjects()
    {
        axe = new Axe(AxeAttack, AxeDurability);
        dummy = new Dummy(DummyHp, DummyExp);
    }

    private const int AxeAttack = 10;
    private const int AxeDurability = 10;
    private const int DummyHp = 10;
    private const int DummyExp = 10;

    private Axe axe;
    private Dummy dummy;

    [Test]
    public void AxeLoosesDurabilityAfterAttack()
    {
        axe.Attack(dummy);
        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");
    }

    [Test]
    public void AxeThrowsExceptionIfBroken()
    {
        axe = new Axe(AxeAttack, 0);

        var error = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.That(error?.Message, Is.EqualTo("Axe is broken."));
    }

    [Test]
    public void VerifyAxeAttackPoints()
    {
        Assert.That(axe.AttackPoints, Is.EqualTo(10));
    }
}