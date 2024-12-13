using padrao_bridge.Interfaces;

namespace padrao_bridge.Shapes;

public class Circle : Shape
{
    public Circle(IColor color) : base(color) { }
}