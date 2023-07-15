using Factory;

namespace AbstractFactory.Figure;

public class Triangle : IShape
{
	public void Draw()
	{
		Console.WriteLine("Basic triangle");
	}
}
