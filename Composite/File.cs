namespace Composite;

class File : Component
{
	public File(string name) : base(name) { }

	public override void Add(Component component) { }
	public override void Remove(Component component) { }
	public override void Print()
		=> Console.WriteLine(new string('\t', numberOfTabs + 1) + name);
}
