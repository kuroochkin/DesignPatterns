namespace Builder.HtmlBuilder;

public class HtmlBuilder
{
    private readonly string rootName;
    protected HtmlElement root = new HtmlElement();

    public HtmlBuilder(string rootName) // "ul"
    {
        this.rootName = rootName;
        root.Name = rootName;
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);
        return this;
    }

    public override string ToString() => root.ToString();

    public void Clear()
    {
        root = new HtmlElement { Name = rootName };
    }

    public HtmlElement Build() => root;

    public static implicit operator HtmlElement(HtmlBuilder builder)
    {
        return builder.root;
    }
}
