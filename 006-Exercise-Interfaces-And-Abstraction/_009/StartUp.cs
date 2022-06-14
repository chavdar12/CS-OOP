namespace _009;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var operations = Console.ReadLine();

        while (operations != "End")
        {
            var info = operations.Split();

            var name = info[0];
            var country = info[1];
            var age = int.Parse(info[2]);

            IPerson person = new Citizen(name, age, country);
            IResident resident = new Citizen(name, age, country);

            person.GetName();
            resident.GetName();

            operations = Console.ReadLine();
        }
    }
}