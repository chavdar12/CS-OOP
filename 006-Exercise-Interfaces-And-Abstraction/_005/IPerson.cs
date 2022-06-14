namespace _005;

public interface IPerson : IIdentifiable, IBirthable
{
    string Name { get; }

    int Age { get; }
}