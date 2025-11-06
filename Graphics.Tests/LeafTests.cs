using Graphics.Core;
using Xunit;
using System;

public class LeafTests
{
    [Fact]
    public void CircleArea_IsPiR2()
    {
        var c = new Circle(0, 0, 10);
        Assert.Equal(Math.PI * 100, c.GetArea(), precision: 5);
    }

    [Fact]
    public void RectangleArea_IsWidthTimesHeight()
    {
        var r = new Rectangle(0, 0, 10, 20);
        Assert.Equal(200, r.GetArea(), precision: 5);
    }
}
