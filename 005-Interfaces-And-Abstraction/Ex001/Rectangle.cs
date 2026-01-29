namespace Ex001;

public class Rectangle : IDrawable
{
    private int height;
    private int width;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    private int Width { get; }
    private int Height { get; }

    public void Draw()
    {
        DrawLine('*', '*');
        for (var i = 1; i < Height - 2; i++) DrawLine('*', ' ');
        DrawLine('*', '*');
    }

    private void DrawLine(char start, char end)
    {
        Console.WriteLine($"{start}{new string(end, Width - 2)}{start}");
    }
}