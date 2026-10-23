using Ex004;

namespace EncapsulationTests;

public class Ex004Tests
{
    [Test]
    public void PlayersUnderFortyGoToFirstTeam()
    {
        var team = new Team("SoftUni");

        team.AddPlayer(new Person("Asen", "Ivanov", 39, 1000));
        team.AddPlayer(new Person("Boiko", "Borisov", 40, 1000));

        Assert.That(team.ToString(),
            Is.EqualTo($"First team has 1 players.{Environment.NewLine}Reserve team has 1 players."));
    }

    [Test]
    public void ProgramFillsTheTeamAndReportsInvalidPeople()
    {
        var output = ConsoleRunner.Run(typeof(Team).Assembly,
            "3\nAsen Ivanov 20 2200\nBoiko Borisov 57 3333\nAs Iv 20 2200\n");

        Assert.That(output, Is.EqualTo(
            "First name cannot contain fewer than 3 symbols!\nFirst team has 1 players.\nReserve team has 1 players."));
    }
}
