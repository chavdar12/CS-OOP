using Ex004;

[TestFixture]
public class ArenaTests
{
    [SetUp]
    public void Setup()
    {
        player = new Warrior("Caesar", 25, 100);
        enemy = new Warrior("Octavian", 15, 50);
        arena = new Arena();
        arena.Enroll(player);
        arena.Enroll(enemy);
        warriors = new List<Warrior>();
    }

    private Arena arena;
    private IList<Warrior> warriors;
    private Warrior player;
    private Warrior enemy;

    [Test]
    public void VerifyConstructor()
    {
        Assert.IsNotNull(arena, "The constructor is broken!");
    }

    [Test]
    public void VerifyWarriorCollection()
    {
        warriors = new List<Warrior>();
        warriors.Add(player);
        warriors.Add(enemy);
        Assert.That(arena.Warriors, Is.EqualTo(warriors));
    }

    [Test]
    public void VerifyEnrollMethod()
    {
        const int expected = 3;
        var temp = new Warrior("Temp", 2, 3);
        arena.Enroll(temp);
        Assert.That(arena.Count, Is.EqualTo(expected));
    }

    [Test]
    public void EnrollMethodThrowsExceptionWhenWarriorWithTheSameNameIsFound()
    {
        Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("Caesar", 5, 25)));
    }

    [Test]
    public void VerifyFightMethod()
    {
        var attacker = player.Name;
        var defender = enemy.Name;
        arena.Fight(attacker, defender);
        Assert.That(player.HP, Is.EqualTo(85));
        Assert.That(enemy.HP, Is.EqualTo(25));
    }

    [Test]
    public void FightMethodThrowsExceptionWhenAttackerEntityIsNull()
    {
        player = null;
        enemy = new Warrior("Goshy", 5, 6);
        Assert.Throws<InvalidOperationException>(() => arena.Fight(player?.Name, enemy.Name));
    }

    [Test]
    public void FightMethodThrowsExceptionWhenDefenderEntityIsNull()
    {
        player = new Warrior("Peshy", 5, 6);
        enemy = null;
        Assert.Throws<InvalidOperationException>(() => arena.Fight(player.Name, enemy?.Name));
    }
}