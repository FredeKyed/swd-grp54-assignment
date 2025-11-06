namespace Graphics.Core;

public interface IGraphic
{
    void Draw();
    void Move(int dx, int dy);
    double GetArea();
}
