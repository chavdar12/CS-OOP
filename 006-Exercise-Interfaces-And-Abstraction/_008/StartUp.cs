namespace _008;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myList = new MyList();

        var operations = Console.ReadLine().Split();

        foreach (var item in operations) Console.Write($"{addCollection.Add(item)} ");
        Console.WriteLine();

        foreach (var item in operations) Console.Write($"{addRemoveCollection.Add(item)} ");
        Console.WriteLine();

        foreach (var item in operations) Console.Write($"{myList.Add(item)} ");
        Console.WriteLine();

        var times = int.Parse(Console.ReadLine());

        for (var i = 0; i < times; i++) Console.Write($"{addRemoveCollection.Remove()} ");
        Console.WriteLine();

        for (var i = 0; i < times; i++) Console.Write($"{myList.Remove()} ");
        Console.WriteLine();
    }
}