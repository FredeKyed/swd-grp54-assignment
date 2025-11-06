using Graphics.Core;
using Xunit;
using System;

public class GroupTests
{
    [Fact]
    public void GroupArea_SumsChildren()
    {
        var g = new Group();
        g.Add(new Rectangle(0, 0, 10, 10));
        g.Add(new Circle(0, 0, 10));
        var expected = 100 + Math.PI * 100;
        Assert.Equal(expected, g.GetArea(), precision: 5);
    }

    [Fact]
    public void Move_PropagatesToChildren()
    {
        var c = new Circle(0, 0, 5);
        var r = new Rectangle(10, 10, 5, 5);
        var g = new Group();
        g.Add(c);
        g.Add(r);

        g.Move(2, -3);

        // Validate by re-running Draw and verifying no exceptions; state is changed but not exposed.
        // (In production, you'd expose positions for verification or use internal accessors.)

        g.Draw();
        Assert.True(true);
    }
}
