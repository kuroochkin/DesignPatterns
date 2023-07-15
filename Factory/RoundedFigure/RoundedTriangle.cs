using Factory;

namespace AbstractFactory.RoundedFigure;

public class RoundedTriangle : IShape
{
	public void Draw()
	{
		Console.WriteLine("Rounded triangle");
	}
}
