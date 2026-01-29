using Ex003;

var neededHeroes = int.Parse(Console.ReadLine());
var raid = new List<BaseHero>();

while (raid.Count != neededHeroes)
{
    var name = Console.ReadLine();
    var heroClass = Console.ReadLine();

    switch (heroClass)
    {
        case nameof(Paladin):
            raid.Add(new Paladin(name));
            break;
        case nameof(Druid):
            raid.Add(new Druid(name));
            break;
        case nameof(Rogue):
            raid.Add(new Rogue(name));
            break;
        case nameof(Warrior):
            raid.Add(new Warrior(name));
            break;
        default:
            Console.WriteLine("Invalid hero!");
            break;
    }
}

var bossHp = int.Parse(Console.ReadLine());

foreach (var hero in raid) hero.CastAbility();

var maxDmg = raid.Sum(x => x.Power);
Console.WriteLine(maxDmg >= bossHp ? "Victory!" : "Defeat...");