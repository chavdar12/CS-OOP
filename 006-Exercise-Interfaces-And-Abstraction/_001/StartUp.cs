﻿namespace _001;

public static class StartUp
{
    private static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        IPerson person = new Citizen(name, age);

        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}