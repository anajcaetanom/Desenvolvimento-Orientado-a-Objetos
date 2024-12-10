using padrao_bridge.Interfaces;

namespace padrao_bridge.Shapes;

public abstract class Shape
{
    private IColor _color;

    public Shape(IColor color)
    {
        _color = color;
    }
    
    public abstract void Draw();
}