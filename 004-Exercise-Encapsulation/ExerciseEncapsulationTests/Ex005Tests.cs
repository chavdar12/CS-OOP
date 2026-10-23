using Ex005;

namespace ExerciseEncapsulationTests;

public class Ex005Tests
{
    [Test]
    public void RatingIsRoundedAverageOfPlayerStats()
    {
        var team = new Team("Arsenal");
        Assert.That(team.Rating, Is.EqualTo(0));

        team.AddPlayer(new Player("Gibbs", 75, 85, 84, 92, 67));

        Assert.That(team.Rating, Is.EqualTo(81));
    }

    [Test]
    public void RemovingMissingPlayerThrows()
    {
        var error = Assert.Throws<InvalidOperationException>(() => new Team("Arsenal").RemovePlayer("Nobody"));
        Assert.That(error.Message, Is.EqualTo("Player Nobody is not in Arsenal team."));
    }

    [Test]
    public void StatOutOfRangeThrows()
    {
        var error = Assert.Throws<ArgumentException>(() => new Player("Gibbs", 101, 85, 84, 92, 67));
        Assert.That(error.Message, Is.EqualTo("Endurance should be between 0 and 100."));
    }

    [Test]
    public void ProgramHandlesTeamCommands()
    {
        var output = ConsoleRunner.Run(typeof(Team).Assembly,
            "Team;Arsenal\nAdd;Arsenal;Kieran_Gibbs;75;85;84;92;67\nAdd;Arsenal;Aaron_Ramsey;95;82;82;89;68\n" +
            "Remove;Arsenal;Aaron_Ramsey\nAdd;Chelsea;X;1;1;1;1;1\nRating;Arsenal\nEND\n");

        Assert.That(output, Is.EqualTo("Team Chelsea does not exist.\nArsenal - 81"));
    }
}
