using _007.Interfaces;
using _007.Models;

namespace _007;

public class StartUp
{
    private static void Main(string[] args)
    {
        var soldiers = new List<ISoldier>();

        var command = Console.ReadLine();

        while (command != "End")
        {
            var operations = command.Split();
            var type = operations[0];

            switch (type)
            {
                case nameof(Private):
                {
                    var id = operations[1];
                    var firstName = operations[2];
                    var lastName = operations[3];
                    var salary = decimal.Parse(operations[4]);

                    soldiers.Add(new Private(id, firstName, lastName, salary));
                    break;
                }
                case nameof(LieutenantGeneral):
                {
                    var id = operations[1];
                    var firstName = operations[2];
                    var lastName = operations[3];
                    var salary = decimal.Parse(operations[4]);

                    var privates = new List<Private>();

                    for (var i = 5; i < operations.Length; i++)
                    {
                        var check = (Private) soldiers.FirstOrDefault(x => x.Id == operations[i]);

                        privates.Add(check);
                    }

                    soldiers.Add(new LieutenantGeneral(id, firstName, lastName, salary, privates));
                    break;
                }
                case nameof(Engineer):
                    try
                    {
                        var id = operations[1];
                        var firstName = operations[2];
                        var lastName = operations[3];
                        var salary = decimal.Parse(operations[4]);
                        var corp = operations[5];

                        var repairs = new List<Repair>();

                        for (var i = 6; i < operations.Length; i += 2)
                            repairs.Add(new Repair(operations[i], int.Parse(operations[i + 1])));

                        soldiers.Add(new Engineer(id, firstName, lastName, salary, corp, repairs));
                    }
                    catch (ArgumentException)
                    {
                    }

                    break;
                case nameof(Commando):
                {
                    var id = operations[1];
                    var firstName = operations[2];
                    var lastName = operations[3];
                    var salary = decimal.Parse(operations[4]);
                    var corp = operations[5];

                    var missions = new List<Mission>();

                    for (var i = 6; i < operations.Length; i += 2)
                        try
                        {
                            missions.Add(new Mission(operations[i], operations[i + 1]));
                        }
                        catch (ArgumentException)
                        {
                        }

                    soldiers.Add(new Commando(id, firstName, lastName, salary, corp, missions));
                    break;
                }
                case nameof(Spy):
                {
                    var id = operations[1];
                    var firstName = operations[2];
                    var lastName = operations[3];
                    var codeNumber = int.Parse(operations[4]);

                    soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                    break;
                }
            }

            command = Console.ReadLine();
        }

        foreach (var soldier in soldiers) Console.WriteLine(soldier);
    }
}