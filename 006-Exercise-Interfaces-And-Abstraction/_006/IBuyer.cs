﻿namespace _006;

public interface IBuyer
{
    string Name { get; }
    int Age { get; }
    int Food { get; }
    void BuyFood();
}