using System;

namespace Graphics.Core;

public sealed class Circle : IGraphic
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int R { get; }

    public Circle(int x, int y, int r)
    {
        if (r <= 0) throw new ArgumentOutOfRangeException(nameof(r), "Radius must be positive.");
        X = x; Y = y; R = r;
    }

    public void Draw() => Console.WriteLine($"Circle at ({X},{Y}) r={R}");
    public void Move(int dx, int dy) { X += dx; Y += dy; }
    public double GetArea() => Math.PI * R * R;
}
