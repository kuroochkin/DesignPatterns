using AbstractFactory.RoundedFigure;
using Factory;

namespace AbstractFactory.Factory;

public class RoundedShapeFactory : ShapeFactory
{
    public override IShape Create(Shape shape)
    {
        switch (shape)
        {
            case Shape.Square:
                return new RoundedSquare();
            case Shape.Triangle:
                return new RoundedTriangle();
            default:
                throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
        }
    }
}
