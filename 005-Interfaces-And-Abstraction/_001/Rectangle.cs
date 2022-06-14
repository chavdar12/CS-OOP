namespace _001;

public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    private int Width { get; set; }
    private int Height { get; set; }

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