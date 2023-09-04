namespace Composite;

class Directory : Component
{
	List<Component> components = new();
	public Directory(string name) : base(name) { }

	public override void Add(Component component)
		=> components.Add(component);
	public override void Remove(Component component)
		=> components.Remove(component);

	public override void Print()
	{
		numberOfTabs++;
		Console.WriteLine(new string('\t', numberOfTabs) + "Узел: " + name);
		foreach (Component component in components)
			component.Print();
		numberOfTabs--;
	}
}