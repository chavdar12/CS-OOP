namespace _001;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var times = int.Parse(Console.ReadLine());
        var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
        var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

        for (var i = 0; i < times; i++)
        {
            var info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var action = info[0];
            var type = info[1];
            var distOrAmount = double.Parse(info[2]);

            switch (type)
            {
                case nameof(Car):
                    switch (action)
                    {
                        case "Drive":
                            Console.WriteLine(car.Drive(distOrAmount));
                            break;
                        case "Refuel":
                            car.Refuel(distOrAmount);
                            break;
                    }

                    break;
                case nameof(Truck):
                    switch (action)
                    {
                        case "Drive":
                            Console.WriteLine(truck.Drive(distOrAmount));
                            break;
                        case "Refuel":
                            truck.Refuel(distOrAmount);
                            break;
                    }

                    break;
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
    }
}