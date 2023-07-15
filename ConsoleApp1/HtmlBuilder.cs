namespace Builder;

public class HtmlBuilder
{
	private readonly string rootName;
	protected HtmlElement root = new HtmlElement();

	public HtmlBuilder(string rootName) // "ul"
	{
		this.rootName = rootName;
		root.Name = rootName;
	}

	public void AddChild(string childName, string childText)
	{
		var e = new HtmlElement(childName, childText);
		root.Elements.Add(e);
	}

	public override string ToString() => root.ToString();

	public void Clear()
	{
		root = new HtmlElement { Name = rootName };
	}

	public HtmlElement Build() => root;
	
}
