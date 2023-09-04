namespace Composite;

abstract class Component
{
	protected static int numberOfTabs = -1;
	protected string name;
	public Component(string name)
		=> this.name = name;
	public abstract void Add(Component component);
	public abstract void Remove(Component component);
	public abstract void Print();
}