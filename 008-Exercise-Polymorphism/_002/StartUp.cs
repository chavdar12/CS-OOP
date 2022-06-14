using System;

namespace _002;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        var times = int.Parse(Console.ReadLine());
        var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
        var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
        var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

        for (var i = 0; i < times; i++)
        {
            var info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var action = info[0];
            var type = info[1];
            var distOrAmount = double.Parse(info[2]);

            switch (type)
            {
                case nameof(Car) when action == "Drive":
                    car.Drive(distOrAmount);
                    break;
                case nameof(Car):
                {
                    if (action == "Refuel") car.Refuel(distOrAmount);
                    break;
                }
                case nameof(Truck) when action == "Drive":
                    truck.Drive(distOrAmount);
                    break;
                case nameof(Truck):
                {
                    if (action == "Refuel") truck.Refuel(distOrAmount);
                    break;
                }
                case nameof(Bus) when action == "Drive":
                    bus.Drive(distOrAmount);
                    break;
                case nameof(Bus) when action == "DriveEmpty":
                    bus.DriveEmpty(distOrAmount);
                    break;
                case nameof(Bus):
                {
                    if (action == "Refuel") bus.Refuel(distOrAmount);
                    break;
                }
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}