using AbstractFactory.Factory;

var basic = ShapeFactory.GetFactory(false);
var basicTriangle = basic.Create(Shape.Triangle);
basicTriangle.Draw();

var roundedSquare = ShapeFactory.GetFactory(true).Create(Shape.Square);
roundedSquare.Draw();
