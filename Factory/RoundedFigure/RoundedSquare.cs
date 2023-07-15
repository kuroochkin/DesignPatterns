using Factory;

namespace AbstractFactory.RoundedFigure;

public class RoundedSquare : IShape
{
	public void Draw()
	{
		Console.WriteLine("Rounded square");
	}
}

