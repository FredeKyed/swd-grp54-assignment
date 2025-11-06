using System;
using System.Globalization;
using Graphics.Core;

static void Print(IGraphic node, int depth = 0)
{
    string pad = new string(' ', depth * 2);

    switch (node)
    {
        case Group g:
            Console.WriteLine($"{pad}Group[{g.Children.Count}] start");
            foreach (var child in g.Children)
                Print(child, depth + 1);
            Console.WriteLine($"{pad}Group end");
            break;

        case Circle c:
            Console.WriteLine($"{pad}Circle at ({c.X},{c.Y}) r={c.R}");
            break;

        case Rectangle r:
            Console.WriteLine($"{pad}Rectangle at ({r.X},{r.Y}) {r.W}x{r.H}");
            break;
    }
}

// ---- Demo setup ----

var leaf1 = new Circle(0, 0, 10);
var leaf2 = new Rectangle(5, 5, 20, 10);

var group1 = new Group();
group1.Add(leaf1);
group1.Add(leaf2);

var group2 = new Group();
group2.Add(new Circle(100, 100, 5));

var root = new Group();
root.Add(group1);
root.Add(group2);

// ---- Demo Output ----

Console.WriteLine("Initial draw:");
Print(root);

Console.WriteLine("Total area: " + root.GetArea().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("\nMove everything by (10, -5) and redraw:");
root.Move(10, -5);
Print(root);

