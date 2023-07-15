using Factory;

namespace AbstractFactory.Factory;

public enum Shape
{
    Square,
    Triangle
}

public abstract class ShapeFactory
{
    public abstract IShape Create(Shape shape);
    public static ShapeFactory GetFactory(bool rounded)
    {
        if (rounded)
            return new RoundedShapeFactory();
        else
            return new BasicShapeFactory();
    }
}
