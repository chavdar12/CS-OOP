using Ex007.Models;

namespace ExerciseInterfacesAndAbstractionTests;

public class Ex007Tests
{
    [Test]
    public void MissionCanBeCompleted()
    {
        var mission = new Mission("Op", "inProgress");

        mission.CompleteMission();

        Assert.That(mission.State, Is.EqualTo("Finished"));
    }

    [Test]
    public void InvalidMissionStateThrows()
    {
        Assert.Throws<ArgumentException>(() => new Mission("Op", "Bogus"));
    }

    [Test]
    public void SpyToString()
    {
        Assert.That(new Spy("5", "James", "Bond", 7).ToString(),
            Is.EqualTo($"Name: James Bond Id: 5{Environment.NewLine}Code Number: 7"));
    }

    [Test]
    public void ProgramPrintsArmySkippingInvalidEntries()
    {
        var output = ConsoleRunner.Run(typeof(Soldier).Assembly,
            "Private 1 Peter Ivanov 22.22\nCommando 13 Sam Peterson 13.1 Airforces Op1 inProgress Op2 Bogus\n" +
            "Private 222 Tony Anderson 80.08\nLieutenantGeneral 3 George Smith 100 222 1\n" +
            "Commando 9 Invalid Corps 1 Navy\nEngineer 7 Pat Smith 10 Marines Boat 2\nEnd\n");

        Assert.That(output, Is.EqualTo(
            "Name: Peter Ivanov Id: 1 Salary: 22.22\n" +
            "Name: Sam Peterson Id: 13 Salary: 13.10\nCorps: Airforces\nMissions:\n   Code Name: Op1 State: inProgress\n" +
            "Name: Tony Anderson Id: 222 Salary: 80.08\n" +
            "Name: George Smith Id: 3 Salary: 100.00\nPrivates:\n" +
            "Name: Tony Anderson Id: 222 Salary: 80.08\nName: Peter Ivanov Id: 1 Salary: 22.22\n" +
            "Name: Pat Smith Id: 7 Salary: 10.00\nCorps: Marines\nRepairs:\n   Part Name: Boat Hours Worked: 2"));
    }
}
