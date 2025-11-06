using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphics.Core;

public sealed class Group : IGraphic
{
    private readonly List<IGraphic> _children = new();

    public IReadOnlyList<IGraphic> Children => _children;

    public void Add(IGraphic child)
    {
        if (child is null) throw new ArgumentNullException(nameof(child));
        if (ReferenceEquals(child, this)) throw new InvalidOperationException("Cannot add group to itself.");
        _children.Add(child);
    }

    public bool Remove(IGraphic child) => _children.Remove(child);

    public void Draw()
    {
        Console.WriteLine($"Group[{_children.Count}] start");
        foreach (var c in _children) c.Draw();
        Console.WriteLine("Group end");
    }

    public void Move(int dx, int dy)
    {
        foreach (var c in _children) c.Move(dx, dy);
    }

    public double GetArea() => _children.Sum(c => c.GetArea());
}
