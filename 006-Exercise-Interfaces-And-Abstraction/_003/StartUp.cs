using Telephony;

namespace _003;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var phoneNumbers = Console.ReadLine().Split();
        var websites = Console.ReadLine().Split();
        var smartPhone = new Smartphone();
        var statPhone = new StationaryPhone();

        foreach (var number in phoneNumbers)
            switch (number.Length)
            {
                case 10:
                    Console.WriteLine(smartPhone.Call(number));
                    break;
                case 7:
                    Console.WriteLine(statPhone.Call(number));
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;
            }

        foreach (var sites in websites) Console.WriteLine(smartPhone.Browse(sites));
    }
}