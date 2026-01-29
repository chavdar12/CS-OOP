namespace Ex002;

public interface ICar
{
    string Model { get; }
    string Color { get; }

    string Start();
    string Stop();
}