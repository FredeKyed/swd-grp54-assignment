using System;

namespace Graphics.Core;

public sealed class Rectangle : IGraphic
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int W { get; }
    public int H { get; }

    public Rectangle(int x, int y, int w, int h)
    {
        if (w <= 0) throw new ArgumentOutOfRangeException(nameof(w), "Width must be positive.");
        if (h <= 0) throw new ArgumentOutOfRangeException(nameof(h), "Height must be positive.");
        X = x; Y = y; W = w; H = h;
    }

    public void Draw() => Console.WriteLine($"Rectangle at ({X},{Y}) {W}x{H}");
    public void Move(int dx, int dy) { X += dx; Y += dy; }
    public double GetArea() => W * H;
}
