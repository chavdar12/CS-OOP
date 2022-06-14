﻿using System;
using _001.Core.Contracts;

namespace CommandPattern.Core;

public class Engine : IEngine
{
    private readonly ICommandInterpreter commandInterpreter;

    public Engine(ICommandInterpreter commandInterpreter)
    {
        this.commandInterpreter = commandInterpreter;
    }

    public void Run()
    {
        while (true)
            try
            {
                var input = Console.ReadLine();
                var result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
    }
}