using AbstractFactory.Figure;
using Factory;

namespace AbstractFactory.Factory;

public class BasicShapeFactory : ShapeFactory
{
    public override IShape Create(Shape shape)
    {
        switch (shape)
        {
            case Shape.Square:
                return new Square();
            case Shape.Triangle:
                return new Triangle();
            default:
                throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
        }
    }
}
