namespace Ex001Tests;

[TestFixture]
public class DummyTests
{
    [SetUp]
    public void SettingUpSubjects()
    {
        axe = new Axe(AxeAttack, AxeDurability);
        dummy = new Dummy(DummyHp, DummyExp);
    }

    private const int AxeAttack = 10;
    private const int AxeDurability = 10;
    private const int DummyHp = 20;
    private const int DummyExp = 50;

    private Axe axe;
    private Dummy dummy;

    [Test]
    public void DummyLoosesHealthWhenAttacked()
    {
        axe.Attack(dummy);
        Assert.That(dummy.Health, Is.EqualTo(10), "Dummy doesn't loose health when attacked!");
    }

    [Test]
    public void DummyThrowsExceptionIfDead()
    {
        axe.Attack(dummy);
        axe.Attack(dummy);

        var error = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.That(error?.Message, Is.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DummyGivesExperienceIfDead()
    {
        axe.Attack(dummy);
        axe.Attack(dummy);

        Assert.That(dummy.GiveExperience(), Is.EqualTo(DummyExp), "Dead Dummy cannot give experience!");
    }

    [Test]
    public void DummyDoesNotGiveExperienceIfAlive()
    {
        var error = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        Assert.That(error?.Message, Is.EqualTo("Target is not dead."));
    }
}