namespace DesignPatterns.Specification;

public enum Size
{
	Small,
	Medium,
	Large,
}

public enum Color
{
	Red, 
	Green,
	Blue,
}

public class Product
{
	public string Name { get; set; }
	public Size Size { get; set; }
	public Color Color { get; set; }

	public Product(string name, Size size, Color color)
	{
		Name = name;
		Size = size;
		Color = color;
	}
}
