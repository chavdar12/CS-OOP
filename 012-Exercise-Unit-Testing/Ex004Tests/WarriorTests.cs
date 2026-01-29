using Ex004;

[TestFixture]
public class WarriorTests
{
    [SetUp]
    public void Setup()
    {
        player = new Warrior("Ragnar", 25, 100);
        enemy = new Warrior("Spartacus", 15, 100);
        minAttackHP = 30;
    }

    private int minAttackHP;
    private Warrior player;
    private Warrior enemy;

    [Test]
    public void VerifyConstructor()
    {
        Assert.That(player, Is.Not.Null, "The constructor is broken!");
        Assert.That(enemy, Is.Not.Null, "The constructor is broken!");
    }

    [Test]
    public void VerifyNameProperty()
    {
        Assert.That(player.Name, Is.EqualTo("Ragnar"), "Property isn't working right!");
    }

    [Test]
    public void NamePropertyThrowsExceptionIfNullEmptyOrWhitespace()
    {
        Assert.Throws<ArgumentException>(() => player = new Warrior(null, 5, 5));
        Assert.Throws<ArgumentException>(() => player = new Warrior(" ", 5, 5));
        Assert.Throws<ArgumentException>(() => player = new Warrior("", 1, 2));
    }

    [Test]
    public void VerifyDamageProperty()
    {
        Assert.That(player.Damage, Is.EqualTo(25), "Property isn't working right!");
    }

    [Test]
    public void DamagePropertyThrowsExceptionIfValueIsNegativeOrZero()
    {
        Assert.Throws<ArgumentException>(() => player = new Warrior("Arthur", 0, 5));
        Assert.Throws<ArgumentException>(() => player = new Warrior("Arthur", -5, 2));
    }

    [Test]
    public void VerifyHealthProperty()
    {
        Assert.That(player.HP, Is.EqualTo(100), "Property isn't working right!");
    }

    [Test]
    public void HealthPropertyThrowsExceptionIfValueIsNegative()
    {
        Assert.Throws<ArgumentException>(() => player = new Warrior("Crixus", 55, -10));
    }

    [Test]
    public void VerifyAttackMethod()
    {
        player.Attack(enemy);
        Assert.That(enemy.HP, Is.EqualTo(75));
    }

    [Test]
    public void AttackMethodSetsEnemyHpToZero()
    {
        player = new Warrior("Temp", 150, 100);
        player.Attack(enemy);
        Assert.That(enemy.HP, Is.EqualTo(0));
    }

    [Test]
    public void AttackMethodThrowsExceptionIfHpIsLowerThanTheEnemy()
    {
        player = new Warrior("Temp", 11, 25);
        Assert.Throws<InvalidOperationException>(() => player.Attack(enemy));
    }

    [Test]
    public void AttackMethodThrowsExceptionIfEnemyHpIsLowerThanTheConstantValue()
    {
        enemy = new Warrior("Temp", 11, 25);
        Assert.Throws<InvalidOperationException>(() => player.Attack(enemy));
    }

    [Test]
    public void AttackMethodThrowsExceptionIfEnemyDamageIsHigherThanPlayerHp()
    {
        player = new Warrior("Temp", 15, 35);
        enemy = new Warrior("Temp", 60, 55);
        Assert.Throws<InvalidOperationException>(() => player.Attack(enemy));
    }
}